﻿using NoteApp.Model;
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
            this.AllNotesListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryAnswerLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllNotesListBox
            // 
            this.AllNotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllNotesListBox.FormattingEnabled = true;
            this.AllNotesListBox.Location = new System.Drawing.Point(12, 54);
            this.AllNotesListBox.Name = "AllNotesListBox";
            this.AllNotesListBox.Size = new System.Drawing.Size(267, 355);
            this.AllNotesListBox.TabIndex = 0;
            this.AllNotesListBox.SelectedIndexChanged += new System.EventHandler(this.AllNotesListBox_SelectedIndexChanged);
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
            // CategoryAnswerLabel
            // 
            this.CategoryAnswerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryAnswerLabel.AutoSize = true;
            this.CategoryAnswerLabel.Location = new System.Drawing.Point(345, 54);
            this.CategoryAnswerLabel.Name = "CategoryAnswerLabel";
            this.CategoryAnswerLabel.Size = new System.Drawing.Size(33, 13);
            this.CategoryAnswerLabel.TabIndex = 6;
            this.CategoryAnswerLabel.Text = "Work";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(295, 76);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 7;
            this.CreatedLabel.Text = "Created:";
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
            this.FileToolStripMenu,
            this.EditToolStripMenu,
            this.HelpToolStripMenu});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 10;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenu});
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            this.FileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenu.Text = "File";
            // 
            // ExitToolStripMenu
            // 
            this.ExitToolStripMenu.Name = "ExitToolStripMenu";
            this.ExitToolStripMenu.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenu.Text = "Exit";
            this.ExitToolStripMenu.Click += new System.EventHandler(this.ExitToolStripMenu_Click);
            // 
            // EditToolStripMenu
            // 
            this.EditToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenu,
            this.EditNoteToolStripMenu,
            this.RemoveNoteToolStripMenu});
            this.EditToolStripMenu.Name = "EditToolStripMenu";
            this.EditToolStripMenu.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenu.Text = "Edit";
            // 
            // AddNoteToolStripMenu
            // 
            this.AddNoteToolStripMenu.Name = "AddNoteToolStripMenu";
            this.AddNoteToolStripMenu.Size = new System.Drawing.Size(146, 22);
            this.AddNoteToolStripMenu.Text = "Add Note";
            this.AddNoteToolStripMenu.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenu
            // 
            this.EditNoteToolStripMenu.Name = "EditNoteToolStripMenu";
            this.EditNoteToolStripMenu.Size = new System.Drawing.Size(146, 22);
            this.EditNoteToolStripMenu.Text = "Edit Note";
            this.EditNoteToolStripMenu.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenu
            // 
            this.RemoveNoteToolStripMenu.Name = "RemoveNoteToolStripMenu";
            this.RemoveNoteToolStripMenu.Size = new System.Drawing.Size(146, 22);
            this.RemoveNoteToolStripMenu.Text = "Remove Note";
            this.RemoveNoteToolStripMenu.Click += new System.EventHandler(this.RemoveNoteToolStripMenu_Click);
            // 
            // HelpToolStripMenu
            // 
            this.HelpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenu});
            this.HelpToolStripMenu.Name = "HelpToolStripMenu";
            this.HelpToolStripMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenu.Text = "Help";
            // 
            // AboutToolStripMenu
            // 
            this.AboutToolStripMenu.Name = "AboutToolStripMenu";
            this.AboutToolStripMenu.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenu.Text = "About";
            this.AboutToolStripMenu.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Documents",
            "Finance",
            "HealthAndSports",
            "Home",
            "People",
            "Work",
            "Other"});
            this.CategoryComboBox.Location = new System.Drawing.Point(91, 27);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(188, 21);
            this.CategoryComboBox.TabIndex = 11;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoseNotesComboBox_SelectedIndexChanged);
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
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentLabel.ForeColor = System.Drawing.Color.Black;
            this.ContentLabel.Location = new System.Drawing.Point(294, 29);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(314, 22);
            this.ContentLabel.TabIndex = 14;
            this.ContentLabel.Text = "Требования к оформлению кода";
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.BackgroundImage")));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 421);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Padding = new System.Windows.Forms.Padding(40);
            this.AddNoteButton.Size = new System.Drawing.Size(20, 20);
            this.AddNoteButton.TabIndex = 15;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.BackgroundImage")));
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditNoteButton.Location = new System.Drawing.Point(35, 423);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(20, 20);
            this.EditNoteButton.TabIndex = 16;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.BackgroundImage")));
            this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteNoteButton.Location = new System.Drawing.Point(58, 421);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(20, 20);
            this.DeleteNoteButton.TabIndex = 17;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Name = "contextMenuStrip1";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(298, 99);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ReadOnly = true;
            this.NotesTextBox.Size = new System.Drawing.Size(490, 342);
            this.NotesTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.CategoryAnswerLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.AllNotesListBox);
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

        private System.Windows.Forms.ListBox AllNotesListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CategoryAnswerLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenu;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenu;
        private System.Windows.Forms.TextBox NotesTextBox;
    }
}

