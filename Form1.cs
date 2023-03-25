using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormDBConnect.DB;

namespace WindowsFormDBConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notesInfo.Text = NotesRepository.ShowNotes();
        }

        //Функция за бутона за добавяне на бележка
        private void button1_Click(object sender, EventArgs e)
        {
            notesInfo.Text = "";
            string enteredNoteText = note.Text;
            NotesRepository.AddNote(enteredNoteText);
            notesInfo.Text = NotesRepository.ShowNotes();
            note.Text = "";
        }

        //Функция за бутона за изтриване на бележка
        private void button2_Click(object sender, EventArgs e)
        {
            int idForDel = int.Parse(idForDelete.Text);
            NotesRepository.DeleteNote(idForDel);
            notesInfo.Text = NotesRepository.ShowNotes();
            idForDelete.Text = "";
        }

        //Функция за бутона за търсене на бележка
        private void button3_Click(object sender, EventArgs e)
        {
            string stringForSearch = searchStringBox.Text;
            notesInfo.Text = NotesRepository.SearchString(stringForSearch);
        }

        //Функция за бутона за обновяване на бележка
        private void button4_Click(object sender, EventArgs e)
        {
            int idForUpdate = int.Parse(updateBoxID.Text);
            string textForUpdate = updateBoxText.Text;
            NotesRepository.UpdateNote(idForUpdate, textForUpdate);
            notesInfo.Text = NotesRepository.ShowNotes();
            updateBoxID.Text = "";
            updateBoxText.Text = "";
        }
    }
}