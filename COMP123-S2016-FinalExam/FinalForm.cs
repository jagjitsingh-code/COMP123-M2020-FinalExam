/////////////////////////////////////////////////////////////////////
//FileName: FinalForm.cs
//Author's name: Jagjit singh
//StudentID : 301106044
//Changes Made : The Load Method of this form should use the Program.character object and fill out the Text values of the TextBox controls contained in this form
//////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When we click aboutToolStripMenuItem_Click a new about box appears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Back Button is pressed we go to pervious form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        /// <summary>
        /// when exitToolStripMenuItem_Click is clicked we exit from Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        ///When we load the final form it gets firstname and lastname textbox filled with Program.Character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FinalForm_Load(object sender, EventArgs e)
        {
            // set  Program.character.FirstName and Program.character.LastName using textbox values
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;

        }
    }
}
