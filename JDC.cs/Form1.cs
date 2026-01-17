using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        private string projectRoot;
        private string filePath;
        public Form1()
        {
            InitializeComponent();
            projectRoot = Path.GetFullPath(Path.Combine
                (AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            filePath = Path.Combine(projectRoot, "notes.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNotes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          clearNotes();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            removeNotes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            addNotes();

            loadNotes();
        }

     
       private void AddNote()
        {
            if (string.IsNullOrWhiteSpace(lstNote.Text))
            {
                MessageBox.Show("Please enter a note.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstNote.Items.Add(lstNote.Text);
            lstNote.Clear();
        }

        private void RemoveNote()
        {
           
            {
                MessageBox.Show("Please select a note to remove.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstNote.Items.RemoveAt(lstNote.SelectedIndex);
        }

        private void ClearNotes()
        {
            lstBox.Items.Clear();
        }

        
    }
}
        
       








    }
}