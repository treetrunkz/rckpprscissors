using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();
            game.Play();
//             string connString = @"Server =.\SQL2k20; Database = SampleDB; Trusted_Connection = True;";

//             int gameId, playerID;
//             string gameCode, gameFirstPlayer, gameSecondPlayer, playerCode, playerDescr;


//             try
//             {
//                 using (SqlConnection conn = new SqlConnection(connString))
//                 {
                
                
//                 string query = @"SELECT * FROM [dbo].[fnGetGameInfo](@gameId);";

//                 SqlCommand cmd = new SqlCommand(query, conn);

//                 SqlParameter param1 = new SqlParameter();
//                 param1.ParameterName = "@gameID";
//                 param1.SqlDbType = SqlDbType.Int;
//                 param1.Value = int.Parse(args[0].ToString());
//  //pass parameter to the SQL Command
//                     cmd.Parameters.Add(param1);

//                     //open connection
//                     conn.Open();

//                     //execute the SQLCommand
//                     SqlDataReader dr = cmd.ExecuteReader();

//                     Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
//                     Console.WriteLine("Retrieved records:");

//                     //check if there are records
//                     if (dr.HasRows)
//                     {
//                         while (dr.Read())
//                         {
//                             gameID = dr.GetInt32(0);
//                             gameCode = dr.GetString(1);
//                             gameFirstPlayer = dr.GetString(2);
//                             gameSecondPlayer = dr.GetString(3);
//                             gameID = dr.GetInt32(4);
//                             gameCode = dr.GetString(5);
//                             gameDescr = dr.GetString(6);

//                             //display retrieved record
//                             Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", empID.ToString(), empCode, empFirstName, empLastName, locationID, locationCode, locationDescr);
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("No data found.");
//                     }

//                     //close data reader
//                     dr.Close();

//                     //close connection
//                     conn.Close();
//                 }
//             }
//             catch (Exception ex)
//             {
//                 //display error message
//                 Console.WriteLine("Exception: " + ex.Message);
//             }


        }
    }

}               
