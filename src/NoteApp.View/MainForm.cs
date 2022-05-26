using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class NoteApp : Form
    {
        /// <summary>
        /// Объект типа Project, хранящий в себе данные обо всех заметках
        /// </summary>
        private Project _project = new Project();



        public NoteApp()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editNoteButton_Click(object sender, EventArgs e)
        {

        }
        private void UpdateListBox()
        {
            notesListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                notesListBox.Items.Add(_currentNotes[i].Title);
            }
        }
        /// <summary>
        /// Список отображаемых заметок на экране
        /// </summary>
        private List<Note> _currentNotes;

        /// <summary>
        /// Добавляет заметку
        /// </summary>
        private void AddNote()
        {
            NoteForm noteForm = new NoteForm();
            noteForm.Note = null;
            noteForm.ShowDialog();
            if (noteForm.Note != null)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdateListBox();
                notesListBox.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// Добавление случайно созданных заметок
        /// </summary>
        private void AddRandomNotes()
        {
            string[] testNoteTitle = { "Test1", "Test2", "Test3", "Test4", "Test5" };
            string[] testNoteText = { "Hello", "Bye", "Good morning", "Good afternoon",
                                        "Good evening", "Good night" };
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int enumIndex = random.Next(0, 7);
                int titleIndex = random.Next(0, testNoteTitle.Length - 1);
                int textIndex = random.Next(0, testNoteText.Length - 1);
                NoteCategory randomNoteCategoryEnum = (NoteCategory)enumIndex;
                string randomNoteTitle = testNoteTitle[titleIndex];
                string randomNoteText = testNoteText[textIndex];
                _project.Notes.Add(new Note(randomNoteTitle, randomNoteCategoryEnum,
                    randomNoteText));
            }
        }
        /// <summary>
        /// Добавляет случайно созданные заметки для тестирования программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRandomNotes();
            OutputByCategory();
            UpdateListBox();
        }
        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = _noteCategoryTools.CategoriesByString
                    [CategoryComboBox.SelectedItem.ToString()]; 
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm add_form = new NoteForm();
            add_form.Show();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm edit_form = new NoteForm();
            edit_form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
