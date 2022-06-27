using NoteApp.Model;
using System;
using System.Collections.Generic;

namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryAnswerTitle = new System.Windows.Forms.Label();
            this.CreatedDateLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteItemsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNotesItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpItemStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutItemsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryTitleComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContentLabelTitle = new System.Windows.Forms.Label();
            this.AddNotesButton = new System.Windows.Forms.Button();
            this.EditNotesButton = new System.Windows.Forms.Button();
            this.DeleteNotesButton = new System.Windows.Forms.Button();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NoteTextPlace = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(12, 54);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(267, 355);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.AllNotesListBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 29);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 4;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(295, 54);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryAnswerTitle
            // 
            this.CategoryAnswerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryAnswerTitle.AutoSize = true;
            this.CategoryAnswerTitle.Location = new System.Drawing.Point(345, 54);
            this.CategoryAnswerTitle.Name = "CategoryAnswerTitle";
            this.CategoryAnswerTitle.Size = new System.Drawing.Size(33, 13);
            this.CategoryAnswerTitle.TabIndex = 6;
            this.CategoryAnswerTitle.Text = "Work";
            // 
            // CreatedDateLabel
            // 
            this.CreatedDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedDateLabel.AutoSize = true;
            this.CreatedDateLabel.Location = new System.Drawing.Point(295, 76);
            this.CreatedDateLabel.Name = "CreatedDateLabel";
            this.CreatedDateLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedDateLabel.TabIndex = 7;
            this.CreatedDateLabel.Text = "Created:";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(446, 76);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 8;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItemStripMenu,
            this.EditItemStripMenu,
            this.HelpItemStripMenu});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 10;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileItemStripMenu
            // 
            this.FileItemStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitItemStripMenu});
            this.FileItemStripMenu.Name = "FileItemStripMenu";
            this.FileItemStripMenu.Size = new System.Drawing.Size(37, 20);
            this.FileItemStripMenu.Text = "File";
            // 
            // ExitItemStripMenu
            // 
            this.ExitItemStripMenu.Name = "ExitItemStripMenu";
            this.ExitItemStripMenu.Size = new System.Drawing.Size(93, 22);
            this.ExitItemStripMenu.Text = "Exit";
            this.ExitItemStripMenu.Click += new System.EventHandler(this.ExitToolStripMenu_Click);
            // 
            // EditItemStripMenu
            // 
            this.EditItemStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteItemsStripMenu,
            this.EditNotesItemStripMenu,
            this.RemoveNoteItemStripMenu});
            this.EditItemStripMenu.Name = "EditItemStripMenu";
            this.EditItemStripMenu.Size = new System.Drawing.Size(39, 20);
            this.EditItemStripMenu.Text = "Edit";
            // 
            // AddNoteItemsStripMenu
            // 
            this.AddNoteItemsStripMenu.Name = "AddNoteItemsStripMenu";
            this.AddNoteItemsStripMenu.Size = new System.Drawing.Size(146, 22);
            this.AddNoteItemsStripMenu.Text = "Add Note";
            this.AddNoteItemsStripMenu.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNotesItemStripMenu
            // 
            this.EditNotesItemStripMenu.Name = "EditNotesItemStripMenu";
            this.EditNotesItemStripMenu.Size = new System.Drawing.Size(146, 22);
            this.EditNotesItemStripMenu.Text = "Edit Note";
            this.EditNotesItemStripMenu.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteItemStripMenu
            // 
            this.RemoveNoteItemStripMenu.Name = "RemoveNoteItemStripMenu";
            this.RemoveNoteItemStripMenu.Size = new System.Drawing.Size(146, 22);
            this.RemoveNoteItemStripMenu.Text = "Remove Note";
            this.RemoveNoteItemStripMenu.Click += new System.EventHandler(this.RemoveNoteToolStripMenu_Click);
            // 
            // HelpItemStripMenu
            // 
            this.HelpItemStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutItemsStripMenu});
            this.HelpItemStripMenu.Name = "HelpItemStripMenu";
            this.HelpItemStripMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpItemStripMenu.Text = "Help";
            // 
            // AboutItemsStripMenu
            // 
            this.AboutItemsStripMenu.Name = "AboutItemsStripMenu";
            this.AboutItemsStripMenu.Size = new System.Drawing.Size(107, 22);
            this.AboutItemsStripMenu.Text = "About";
            this.AboutItemsStripMenu.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CategoryTitleComboBox
            // 
            this.CategoryTitleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryTitleComboBox.FormattingEnabled = true;
            this.CategoryTitleComboBox.Items.AddRange(new object[] {
            "All",
            "Documents",
            "Finance",
            "HealthAndSports",
            "Home",
            "People",
            "Work",
            "Other"});
            this.CategoryTitleComboBox.Location = new System.Drawing.Point(91, 27);
            this.CategoryTitleComboBox.Name = "CategoryTitleComboBox";
            this.CategoryTitleComboBox.Size = new System.Drawing.Size(188, 21);
            this.CategoryTitleComboBox.TabIndex = 11;
            this.CategoryTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoseNotesComboBox_SelectedIndexChanged);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(348, 73);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.CreatedDateTimePicker.TabIndex = 12;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(502, 73);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.ModifiedDateTimePicker.TabIndex = 13;
            // 
            // ContentLabelTitle
            // 
            this.ContentLabelTitle.AutoSize = true;
            this.ContentLabelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContentLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentLabelTitle.ForeColor = System.Drawing.Color.Black;
            this.ContentLabelTitle.Location = new System.Drawing.Point(294, 29);
            this.ContentLabelTitle.Name = "ContentLabelTitle";
            this.ContentLabelTitle.Size = new System.Drawing.Size(314, 22);
            this.ContentLabelTitle.TabIndex = 14;
            this.ContentLabelTitle.Text = "Требования к оформлению кода";
            // 
            // AddNotesButton
            // 
            this.AddNotesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNotesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNotesButton.BackgroundImage")));
            this.AddNotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNotesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNotesButton.Location = new System.Drawing.Point(12, 421);
            this.AddNotesButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddNotesButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.AddNotesButton.Name = "AddNotesButton";
            this.AddNotesButton.Padding = new System.Windows.Forms.Padding(40);
            this.AddNotesButton.Size = new System.Drawing.Size(20, 20);
            this.AddNotesButton.TabIndex = 15;
            this.AddNotesButton.UseVisualStyleBackColor = true;
            this.AddNotesButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // EditNotesButton
            // 
            this.EditNotesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNotesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNotesButton.BackgroundImage")));
            this.EditNotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNotesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditNotesButton.Location = new System.Drawing.Point(35, 423);
            this.EditNotesButton.Name = "EditNotesButton";
            this.EditNotesButton.Size = new System.Drawing.Size(20, 20);
            this.EditNotesButton.TabIndex = 16;
            this.EditNotesButton.UseVisualStyleBackColor = true;
            this.EditNotesButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // DeleteNotesButton
            // 
            this.DeleteNotesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNotesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteNotesButton.BackgroundImage")));
            this.DeleteNotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNotesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteNotesButton.Location = new System.Drawing.Point(58, 421);
            this.DeleteNotesButton.Name = "DeleteNotesButton";
            this.DeleteNotesButton.Size = new System.Drawing.Size(20, 20);
            this.DeleteNotesButton.TabIndex = 17;
            this.DeleteNotesButton.UseVisualStyleBackColor = true;
            this.DeleteNotesButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Name = "contextMenuStrip1";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // NoteTextPlace
            // 
            this.NoteTextPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextPlace.Location = new System.Drawing.Point(298, 99);
            this.NoteTextPlace.Multiline = true;
            this.NoteTextPlace.Name = "NoteTextPlace";
            this.NoteTextPlace.ReadOnly = true;
            this.NoteTextPlace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextPlace.Size = new System.Drawing.Size(490, 342);
            this.NoteTextPlace.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoteTextPlace);
            this.Controls.Add(this.DeleteNotesButton);
            this.Controls.Add(this.EditNotesButton);
            this.Controls.Add(this.AddNotesButton);
            this.Controls.Add(this.ContentLabelTitle);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.CategoryTitleComboBox);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.CreatedDateLabel);
            this.Controls.Add(this.CategoryAnswerTitle);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.NotesListBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CategoryAnswerTitle;
        private System.Windows.Forms.Label CreatedDateLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpItemStripMenu;
        private System.Windows.Forms.ComboBox CategoryTitleComboBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ContentLabelTitle;
        private System.Windows.Forms.Button AddNotesButton;
        private System.Windows.Forms.Button EditNotesButton;
        private System.Windows.Forms.Button DeleteNotesButton;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNoteItemsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditNotesItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutItemsStripMenu;
        private System.Windows.Forms.TextBox NoteTextPlace;
    }
}

