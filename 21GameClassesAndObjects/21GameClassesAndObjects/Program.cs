using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a constant for casino name
            const string casinoName = "Grand Hotel and Ca$ino";
        
            //Get player name
            Console.WriteLine("Welcome to the {0}.  Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            //If name is admin, call method to show all logged exceptions and print them to console
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }


            //Loop to handle posisble user input values for initial bank amount
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter valid digits only, no decimals");   
            }


            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //use Player constructor to create new player
                Player player = new Player(playerName, bank);
                //Assign player guid Id
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Libby\Documents\21Log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                //Create new game (using polymorphism
                Game game = new TwentyOneGame();
                //Add player to game
                game += player;
                player.isActivelyPlaying = true;

                //Check if player wants to play and has enough money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //try/catch blocks for error handling
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        //Log exception to dB
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred.  Please contact your system adminstrator");
                        //Log exception to dB
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                //remove player from game
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }

        // Private method to log exceptions to dB //

        private static void UpdateDbWithException(Exception ex)
        {
            //Connection string
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent =ReadWrite; 
                                        MultiSubnetFailover = False";

            //Query string (Parameterized query)
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //Add data types to parameters
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);

                //Add values to parameters
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //Send into to dB
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        //Private method that returns list of exceptions
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent =ReadWrite; 
                                        MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            //Create empty list to hold dB exception entity values
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                //open connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //while reader is open
                while (reader.Read())
                {
                    // Convert entity values to correct data format and store in Exceptions list
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.id = Convert.ToInt32(reader["Id"]);
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

