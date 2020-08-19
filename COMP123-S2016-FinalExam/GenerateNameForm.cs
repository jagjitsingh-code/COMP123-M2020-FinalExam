/////////////////////////////////////////////////////////////////////
//FileName: GenerateNameForm.cs
//Author's name: Jagjit singh
//StudentID : 301106044
//Changes Made :a.	Create a method called GenerateNames. When called, this method will randomly pick First Names and Last Names from the FirstNameListBox and LastNameListBox controls and set the FirstNameTextBox and LastNameTextBox with these values. 
//In the GenerateNameForm’s Load event handler.Call the GenerateNames method.
//In the GenerateNameButton’s click event handler, call the GenerateNames method.
//d.In the GenerateNameButton’s click event handler, set the value of the FirstName property of the Program.character object to the value of text property of the FirstNameTextBox control 
//e.In the GenerateNameButton’s click event handler, set the value of the LastName property of the Program.character object to the value of text property of the LastNameTextBox control.
//f.In the NextButton’s click event handler, instantiate a new AbilityGeneratorForm object of the AbilityGeneratorForm class. 
//g.In the NextButton’s click event handler, call the Show() method of AbilityGeneratorForm object and the Hide() method of the GenerateNameForm 
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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
            GenerateNames();
        }
        /// <summary>
        /// When we click on Generate Button GenerateNames is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        /// <summary>
        /// Generate name select a first name , last name  randomly, set FirstNameTextBox, LastNameTextBox with randomly selected first name and last name
        /// </summary>

        public void GenerateNames()
        {

            // Creting instance of random class

            var random = new Random();

            // create a new random index for first and last name list box
            int indexFirstName = random.Next(0, FirstNameListBox.Items.Count);
            int indexLastName = random.Next(0, LastNameListBox.Items.Count);

            //Use first name and last name and set there values using random indexes
            String FirstName = Convert.ToString(FirstNameListBox.Items[indexLastName]);
            String LastName = Convert.ToString(LastNameListBox.Items[indexFirstName]);

            // set text values of text boxes FirstNameTextBox, LastNameTextBox
            this.FirstNameTextBox.Text = FirstName;
            this.LastNameTextBox.Text = LastName;

            //set  Program.character.FirstName,  Program.character.LastName
            Program.character.FirstName = this.FirstNameTextBox.Text;

            Program.character.LastName = this.LastNameTextBox.Text;



        }
        /// <summary>
        /// When we click on next button AbilityGeneratorform is instanstiated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Create an insatnce of AbilityGeneratorForm
            AbilityGeneratorForm agf = new AbilityGeneratorForm();
            // Hide GenerateName Form
            this.Hide();
            // Show AbilityGeneratorForm
            agf.Show();
        }
    }
}
