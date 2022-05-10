namespace NoteApp.View
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListBox notesListBox;
            this.titleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.createdNoteLabel = new System.Windows.Forms.Label();
            this.titleNoteBox = new System.Windows.Forms.ComboBox();
            this.categoryNoteBox = new System.Windows.Forms.ComboBox();
            this.modifiedNoteLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createdTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            notesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 36);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // createdNoteLabel
            // 
            this.createdNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdNoteLabel.AutoSize = true;
            this.createdNoteLabel.Location = new System.Drawing.Point(13, 63);
            this.createdNoteLabel.Name = "createdNoteLabel";
            this.createdNoteLabel.Size = new System.Drawing.Size(47, 13);
            this.createdNoteLabel.TabIndex = 2;
            this.createdNoteLabel.Text = "Created:";
            this.createdNoteLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // titleNoteBox
            // 
            this.titleNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleNoteBox.FormattingEnabled = true;
            this.titleNoteBox.Location = new System.Drawing.Point(66, 6);
            this.titleNoteBox.Name = "titleNoteBox";
            this.titleNoteBox.Size = new System.Drawing.Size(722, 21);
            this.titleNoteBox.TabIndex = 3;
            // 
            // categoryNoteBox
            // 
            this.categoryNoteBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryNoteBox.FormattingEnabled = true;
            this.categoryNoteBox.Location = new System.Drawing.Point(66, 33);
            this.categoryNoteBox.Name = "categoryNoteBox";
            this.categoryNoteBox.Size = new System.Drawing.Size(138, 21);
            this.categoryNoteBox.TabIndex = 4;
            // 
            // modifiedNoteLabel
            // 
            this.modifiedNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedNoteLabel.AutoSize = true;
            this.modifiedNoteLabel.Location = new System.Drawing.Point(210, 63);
            this.modifiedNoteLabel.Name = "modifiedNoteLabel";
            this.modifiedNoteLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedNoteLabel.TabIndex = 7;
            this.modifiedNoteLabel.Text = "Modified:";
            this.modifiedNoteLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // notesListBox
            // 
            notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            notesListBox.FormattingEnabled = true;
            notesListBox.Location = new System.Drawing.Point(12, 87);
            notesListBox.Name = "notesListBox";
            notesListBox.Size = new System.Drawing.Size(776, 329);
            notesListBox.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(632, 422);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(713, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createdTimePicker
            // 
            this.createdTimePicker.Location = new System.Drawing.Point(66, 60);
            this.createdTimePicker.Name = "createdTimePicker";
            this.createdTimePicker.Size = new System.Drawing.Size(138, 20);
            this.createdTimePicker.TabIndex = 11;
            this.createdTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // modifiedTimePicker
            // 
            this.modifiedTimePicker.Location = new System.Drawing.Point(266, 60);
            this.modifiedTimePicker.Name = "modifiedTimePicker";
            this.modifiedTimePicker.Size = new System.Drawing.Size(138, 20);
            this.modifiedTimePicker.TabIndex = 12;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifiedTimePicker);
            this.Controls.Add(this.createdTimePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(notesListBox);
            this.Controls.Add(this.modifiedNoteLabel);
            this.Controls.Add(this.categoryNoteBox);
            this.Controls.Add(this.titleNoteBox);
            this.Controls.Add(this.createdNoteLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label createdNoteLabel;
        private System.Windows.Forms.ComboBox titleNoteBox;
        private System.Windows.Forms.ComboBox categoryNoteBox;
        private System.Windows.Forms.Label modifiedNoteLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker createdTimePicker;
        private System.Windows.Forms.DateTimePicker modifiedTimePicker;
    }
}