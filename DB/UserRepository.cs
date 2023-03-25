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
        //Функция за показване на всички бележки
        public static string ShowNotes()
        {
            //Осъществяваме връзката с базата данни
            string result = "";
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Взимаме чрез MySQL заявка всички бележки
                string selectQuery = "SELECT * FROM `notes`";
                MySqlCommand command2 = new MySqlCommand(selectQuery, db);
                MySqlDataReader reader = command2.ExecuteReader();

                //Показваме на всички бележки
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

        //Добавяме нова бележка в базата данни
        public static void AddNote(string enteredNoteText)
        {
            //Осъществяваме връзката с базата данни
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Вкарваме чрез MySQL заявка бележката в базата данни
                string insertQuery = "INSERT INTO `notes` (`noteText`) VALUES(@noteText)";
                MySqlCommand command1 = new MySqlCommand(insertQuery, db);
                command1.Parameters.AddWithValue("@noteText", enteredNoteText); 
                command1.ExecuteNonQuery();
            }
        }

        //Изтриваме бележка от базата данни
        public static void DeleteNote(int id)
        {
            //Осъществяваме връзката с базата данни
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Изтриваме чрез MySQL заявка бележката от базата данни
                string query = "DELETE FROM `notes` WHERE id = @id;";
                MySqlCommand command = new MySqlCommand(query, db);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();   
            }
        }



        public static string SearchString(string searchString)
        {
            //Осъществяваме връзката с базата данни
            string result = "";
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Заявка за търсене на текст в бележките чрез SQL заявка
                string selectQuery = "SELECT * FROM `notes` WHERE `noteText` LIKE @searchString";
                MySqlCommand command = new MySqlCommand(selectQuery, db);
                command.Parameters.AddWithValue("@searchString", "%" + searchString + "%");
                MySqlDataReader reader = command.ExecuteReader();

                //Показваме резултатите получени от търсенето в базата данни на екрана
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

        //Обновяваме текста на съществуваща бележка
        public static void UpdateNote(int id, string text)
        {
            //Осъществяваме връзката с базата данни
            MySqlConnection db = Database.GetConnection();
            db.Open();
            using (db)
            {
                //Изпращаме SQL заявка за обновлението на бележка
                string query = "UPDATE `notes` SET `noteText` = @noteText WHERE `id` = @id;";
                MySqlCommand command = new MySqlCommand(query, db);
                command.Parameters.AddWithValue("@noteText", text);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();   
            }
        }
    }
}
