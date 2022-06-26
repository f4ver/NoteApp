using NoteApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Закрытое поле типа Project.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список отображаемых заметок на экране.
        /// </summary>
        private List<Note> _currentNotes;

        /// <summary>
        /// Все заметки.
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// Экземпляр класса ProjectSerializer для сериализации.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary>
        /// Запуск главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = _projectSerializer.LoadFromFile();
            CategoryTitleComboBox.SelectedIndex = 0;
            ClearSelectedNote();
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории.
        /// </summary>
        private int FindProjectIndex(int index)
        {
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                if (_project.Notes[i] == _currentNotes[index])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Вывод заметки по категории.
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryTitleComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = (NoteCategory)Enum.Parse(typeof(NoteCategory),
                    CategoryTitleComboBox.GetItemText(CategoryTitleComboBox.SelectedItem));
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }

        /// <summary>
        /// Обновить элемент ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            NotesListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                NotesListBox.Items.Add(_currentNotes[i].Title);
            }
        }

        /// <summary>
        /// Обновление выбранной заметки.
        /// </summary>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0) || (_currentNotes.Count <= index))
            {
                ClearSelectedNote();
                return;
            }
            Note selectedNote = _currentNotes[index];
            NoteTextPlace.Text = selectedNote.Text;
            ContentLabelTitle.Text = selectedNote.Title;
            CategoryAnswerTitle.Text = selectedNote.Category.ToString();
            CreatedDateTimePicker.Visible = true;
            ModifiedDateTimePicker.Visible = true;
            CreatedDateTimePicker.Value = selectedNote.CreatedAt;
            ModifiedDateTimePicker.Value = selectedNote.ModifiedAt;
        }

        /// <summary>
        /// Очищение заметки с экрана.
        /// </summary>
        private void ClearSelectedNote()
        {
            ContentLabelTitle.Text = "";
            CategoryAnswerTitle.Text = "";
            NoteTextPlace.Text = "";
            CreatedDateTimePicker.Visible = false;
            ModifiedDateTimePicker.Visible = false;
        }

        /// <summary>
        /// Добавление новой заметки.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdateListBox();
                NotesListBox.SelectedIndex = 0;
                _projectSerializer.SaveToFile(_project);
            }   
        }

        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _project.Notes[index];
            index = FindProjectIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = 0;
                OutputByCategory();
                UpdateSelectedNote(NotesListBox.SelectedIndex);
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
            NotesListBox.SelectedIndex = currentIndex;
        }

        /// <summary>
        /// Удалить выбранную заметку.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            index = FindProjectIndex(index);
            var result = MessageBox.Show("Do you really want to remove " + "\"" + 
                NotesListBox.SelectedItem.ToString() + "\"" +
                "?", "Deleting a note", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
                OutputByCategory();
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Изменение выбранной заметки.
        /// </summary>
        private void AllNotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(NotesListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult result = MessageBox.Show(@"Do you really want to exit?", "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Обработчик события для удаления заметки.
        /// </summary>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события для изменения заметки.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
        }

        /// <summary>
        /// Обработчик события Strip Menu для удаления заметки.
        /// </summary>
        private void RemoveNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }
        
        /// <summary>
        /// Завершение программы.
        /// </summary>
        private void ExitToolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Обработчик события для добавления заметки.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события Strip Menu для добавления заметки.
        /// </summary>
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события Strip Menu для изменения заметки.
        /// </summary>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Открытие формы с информацией об авторе.
        /// </summary>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события для выбора категории заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoseNotesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdateListBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
