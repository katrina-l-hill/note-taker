﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking_App
{
    public partial class takerOfNotes : Form
    {
        // create a new data table that's globally accessible
        // acts as the backend for the data grid view for showing the previous notes
        DataTable notes = new DataTable();

        // keeps track of edits of the notes not actively using
        bool editing = false;
        public takerOfNotes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ability to edit data table and add a note for each entry
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            // set data source for the data grid source equal to the data table in the backend

        }

        private void NoteTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoteComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void openNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
