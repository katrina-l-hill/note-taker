namespace Note_Taking_App
{
    partial class takerOfNotes
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
            this.NoteTitle = new System.Windows.Forms.TextBox();
            this.NoteComments = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.previousNotesLabel = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.openNoteButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteTitle
            // 
            this.NoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTitle.Location = new System.Drawing.Point(29, 177);
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.Size = new System.Drawing.Size(503, 30);
            this.NoteTitle.TabIndex = 0;
            this.NoteTitle.TextChanged += new System.EventHandler(this.NoteTitle_TextChanged);
            // 
            // NoteComments
            // 
            this.NoteComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteComments.Location = new System.Drawing.Point(29, 316);
            this.NoteComments.Multiline = true;
            this.NoteComments.Name = "NoteComments";
            this.NoteComments.Size = new System.Drawing.Size(503, 787);
            this.NoteComments.TabIndex = 1;
            this.NoteComments.TextChanged += new System.EventHandler(this.NoteComments_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(29, 124);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(503, 35);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentsLabel
            // 
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.commentsLabel.Location = new System.Drawing.Point(24, 251);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(499, 29);
            this.commentsLabel.TabIndex = 3;
            this.commentsLabel.Text = "Comments:";
            this.commentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(29, 1150);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 59);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(385, 1150);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 59);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // previousNotesLabel
            // 
            this.previousNotesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.previousNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousNotesLabel.Location = new System.Drawing.Point(597, 53);
            this.previousNotesLabel.Name = "previousNotesLabel";
            this.previousNotesLabel.Size = new System.Drawing.Size(503, 35);
            this.previousNotesLabel.TabIndex = 6;
            this.previousNotesLabel.Text = "Previous Notes:";
            this.previousNotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(602, 106);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowHeadersWidth = 62;
            this.previousNotes.RowTemplate.Height = 28;
            this.previousNotes.Size = new System.Drawing.Size(522, 485);
            this.previousNotes.TabIndex = 7;
            // 
            // openNoteButton
            // 
            this.openNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNoteButton.Location = new System.Drawing.Point(602, 618);
            this.openNoteButton.Name = "openNoteButton";
            this.openNoteButton.Size = new System.Drawing.Size(147, 59);
            this.openNoteButton.TabIndex = 8;
            this.openNoteButton.Text = "Open";
            this.openNoteButton.UseVisualStyleBackColor = true;
            this.openNoteButton.Click += new System.EventHandler(this.openNoteButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(210, 1150);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(146, 59);
            this.uploadButton.TabIndex = 9;
            this.uploadButton.Text = "Upload Doc/Img...";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoteButton.Location = new System.Drawing.Point(29, 29);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(146, 59);
            this.newNoteButton.TabIndex = 10;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(786, 618);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 59);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // takerOfNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1136, 1218);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.openNoteButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.previousNotesLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.NoteComments);
            this.Controls.Add(this.NoteTitle);
            this.Name = "takerOfNotes";
            this.Text = "Taker of Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTitle;
        private System.Windows.Forms.TextBox NoteComments;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label previousNotesLabel;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button openNoteButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.Button closeButton;
    }
}

