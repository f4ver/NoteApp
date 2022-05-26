namespace NoteApp.View
{
    partial class NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
            this.optionsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.categoryNoteBox = new System.Windows.Forms.ComboBox();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.editNoteButton = new System.Windows.Forms.Button();
            this.createdNotePicker = new System.Windows.Forms.DateTimePicker();
            this.modifiedNotePicker = new System.Windows.Forms.DateTimePicker();
            this.titleNoteLabel = new System.Windows.Forms.Label();
            this.categoryTitleLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.optionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsMenu
            // 
            this.optionsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optionsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.optionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.optionsMenu.Location = new System.Drawing.Point(0, 0);
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(128, 24);
            this.optionsMenu.TabIndex = 0;
            this.optionsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addNoteToolStripMenuItem.Text = "Add note";
            this.addNoteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editNoteToolStripMenuItem.Text = "Edit note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.showCategoryLabel.AutoSize = true;
            this.showCategoryLabel.Location = new System.Drawing.Point(4, 30);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.showCategoryLabel.TabIndex = 1;
            this.showCategoryLabel.Text = "Show Category:";
            this.showCategoryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // notesListBox
            // 
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.IntegralHeight = false;
            this.notesListBox.Location = new System.Drawing.Point(7, 54);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(234, 355);
            this.notesListBox.TabIndex = 2;
            // 
            // categoryNoteBox
            // 
            this.categoryNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryNoteBox.FormattingEnabled = true;
            this.categoryNoteBox.Location = new System.Drawing.Point(90, 27);
            this.categoryNoteBox.Name = "categoryNoteBox";
            this.categoryNoteBox.Size = new System.Drawing.Size(151, 21);
            this.categoryNoteBox.TabIndex = 3;
            // 
            // addNoteButton
            // 
            this.addNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNoteButton.FlatAppearance.BorderSize = 0;
            this.addNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("addNoteButton.Image")));
            this.addNoteButton.Location = new System.Drawing.Point(5, 424);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(23, 23);
            this.addNoteButton.TabIndex = 4;
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteNoteButton.FlatAppearance.BorderSize = 0;
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNoteButton.Image")));
            this.deleteNoteButton.Location = new System.Drawing.Point(34, 424);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(23, 23);
            this.deleteNoteButton.TabIndex = 5;
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // editNoteButton
            // 
            this.editNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editNoteButton.FlatAppearance.BorderSize = 0;
            this.editNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("editNoteButton.Image")));
            this.editNoteButton.Location = new System.Drawing.Point(63, 424);
            this.editNoteButton.Name = "editNoteButton";
            this.editNoteButton.Size = new System.Drawing.Size(23, 23);
            this.editNoteButton.TabIndex = 6;
            this.editNoteButton.UseVisualStyleBackColor = true;
            this.editNoteButton.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // createdNotePicker
            // 
            this.createdNotePicker.Location = new System.Drawing.Point(301, 74);
            this.createdNotePicker.Name = "createdNotePicker";
            this.createdNotePicker.Size = new System.Drawing.Size(140, 20);
            this.createdNotePicker.TabIndex = 7;
            // 
            // modifiedNotePicker
            // 
            this.modifiedNotePicker.Location = new System.Drawing.Point(503, 74);
            this.modifiedNotePicker.Name = "modifiedNotePicker";
            this.modifiedNotePicker.Size = new System.Drawing.Size(140, 20);
            this.modifiedNotePicker.TabIndex = 8;
            // 
            // titleNoteLabel
            // 
            this.titleNoteLabel.AutoSize = true;
            this.titleNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleNoteLabel.Location = new System.Drawing.Point(247, 27);
            this.titleNoteLabel.Name = "titleNoteLabel";
            this.titleNoteLabel.Size = new System.Drawing.Size(82, 20);
            this.titleNoteLabel.TabIndex = 9;
            this.titleNoteLabel.Text = "Заметка";
            this.titleNoteLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.AutoSize = true;
            this.categoryTitleLabel.Location = new System.Drawing.Point(248, 54);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryTitleLabel.TabIndex = 10;
            this.categoryTitleLabel.Text = "Category:";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(248, 77);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 11;
            this.createdLabel.Text = "Created:";
            this.createdLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(447, 77);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedLabel.TabIndex = 12;
            this.modifiedLabel.Text = "Modified:";
            this.modifiedLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Location = new System.Drawing.Point(251, 100);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(541, 347);
            this.notesTextBox.TabIndex = 13;
            this.notesTextBox.Text = "";
            this.notesTextBox.TextChanged += new System.EventHandler(this.notesTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(301, 50);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 15;
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.modifiedLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.categoryTitleLabel);
            this.Controls.Add(this.titleNoteLabel);
            this.Controls.Add(this.modifiedNotePicker);
            this.Controls.Add(this.createdNotePicker);
            this.Controls.Add(this.editNoteButton);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.categoryNoteBox);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.showCategoryLabel);
            this.Controls.Add(this.optionsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.optionsMenu;
            this.Name = "NoteApp";
            this.Text = "NoteApp";
            this.optionsMenu.ResumeLayout(false);
            this.optionsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label showCategoryLabel;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.ComboBox categoryNoteBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button editNoteButton;
        private System.Windows.Forms.DateTimePicker createdNotePicker;
        private System.Windows.Forms.DateTimePicker modifiedNotePicker;
        private System.Windows.Forms.Label titleNoteLabel;
        private System.Windows.Forms.Label categoryTitleLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}

