/////////////////////////////////////////////////////////////////////
//FileName: SplashForm.cs
//Author's name: Jagjit singh
//StudentID : 301106044
//Changes Made : SplashForm: This form needs to be created.
//a.Add a new form to the project and name it SplashForm.
//b.Set the StartPosition property to CenterScreen .
//c.Set the BackGroundImage property to use the SplashScreen image in the project’s resources.
//d.Set the FormBorderStyle to None
//e.Set the ControlBox, MaximizeBox and MinimizeBox properties to False. 
//f.Set the Form’s Size property to 600, 320 (2 Mark: GUI) Done
//g.Add a Timer control to the form from the Components section of the ToolBox.
//h.Set the Timer control’s properties so that it is enabled with an interval of 3000 milliseconds 
//i.Create the Timer’s tick event handler.
//j.Write code so that the SplashForm is hidden and the GenerateNameForm is shown after the Timer’s tick event is triggered.Ensure that this only happens once.
//k.In the Program.cs file change the Application.Run method to start the SplashForm first

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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This will hide Splash form
            this.Hide();
            //This will stop timer of the splash form or it will continue and at every 3000 ms event is trigerred again and again
            timer1.Stop();
            // main form object is created 
            GenerateNameForm main = new GenerateNameForm();
            // GenerateNameForm show
            main.Show();
         

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
