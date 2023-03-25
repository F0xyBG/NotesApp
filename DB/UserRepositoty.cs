using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormDBConnect.DB
{
    internal class NotesRepository
    {
        public static string ShowNotes()
        {
            string result = "";
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Показване на всички бележки
                string selectQuery = "SELECT * FROM `notes`";
                MySqlCommand command2 = new MySqlCommand(selectQuery, db);
                MySqlDataReader reader = command2.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string note = reader.GetString(1);
                        result += $"ID: {id} | Note: {note} "; 
                        result += "\n";
                        result += "================================================";
                        result += "\n";
                    }
                }
            }

            return result;
        }

        public static void AddNote(string enteredNoteText)
        {
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //add in db
                string insertQuery = "INSERT INTO `notes` (`noteText`) VALUES(@noteText)";
                MySqlCommand command1 = new MySqlCommand(insertQuery, db);
                command1.Parameters.AddWithValue("@noteText", enteredNoteText); 
                command1.ExecuteNonQuery();
            }
        }
    }
}
