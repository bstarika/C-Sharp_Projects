﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();

            if(playerName.ToLower() == "admin") //create a command called admin that will print out a log of exceptions
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(); //exceptions is the list name that will list of exception entity objects. readexceptions() method is defined at bottom of page
                foreach(var exceptions in Exceptions)
                {
                    Console.Write(exceptions.Id + " | ");
                    Console.Write(exceptions.ExceptionType + " | ");
                    Console.Write(exceptions.ExceptionMessage + " | ");
                    Console.Write(exceptions.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?"); //below is an example of exception handling (ex. if a user were to enter in 100 dollars instead of 100)
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //method that takes string that has an out parameter(assigning value to result and sending back), this line casts a string to int
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }

            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName); //{0} = string formatting / variable placeholder in some curly braces (will be players name)
            string answer = Console.ReadLine().ToLower(); //checking answer w/ tolower() method (will check for all with uppercase letters as well)
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                player player = new player(playerName, bank); //create new player object if they want to play, initialize player with name and bank
                game game = new TwentyOneGame(); //polymorphism: twentyonegame is also game, exposes overloaded operators
                game += player; //adding player to the game (overloaded operator)
                player.isActivelyPlaying = true; //property of player, set to true for while loop (when player is actively playing, play the game)
                while (player.isActivelyPlaying && player.Balance >0) //as long as both conditions are met...
                {
                    try
                    {
                        game.Play(); //will play one hand and continue to loop through as long as above conditions are met 
                    }
                    catch (FraudException ex) 
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //whne you type return in void method it ends method 
                    }
                    catch (Exception ex) //general exception, will catch all
                    {
                        Console.WriteLine("An error occured. Please contact system admin.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player; //is player exists while loop, subtract from game (overloaded operator)
                Console.WriteLine("Thank you for playing");  //after game is over
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now"); //don't need else statement, this is if player didn't answer yes to playing game
            Console.Read();
        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";
            //connection string that contains information about DB instance you are connecting to 
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //protects your program from SQL injection by using parameterized queries
            using (SqlConnection connection = new SqlConnection(connectionString)) //"using" is a way of controlling unmanaged external code/resources. Made new instance and will pass it the connectionString. **quick way to add using statement at top of page (different than this using statement) is to right click on SqlConnection (which previously had red underline) quick actions/refactorings, and click using.
            {
                SqlCommand command = new SqlCommand(queryString, connection); //first add data types/parameters 
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //added one parameter, naming its datatype you're protecting against SQL injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //and then add parameter values with gettype() method
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open(); //send above to database
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        private static List<ExceptionEntity> ReadExceptions() //method defined here
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity(); //example of how to access database with c#, have to be careful with typos when mapping this way
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
