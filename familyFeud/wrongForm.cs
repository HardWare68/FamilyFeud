using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace familyFeud
{
    public partial class wrongForm : Form
    {
        public System.Media.SoundPlayer playerBrrt = new System.Media.SoundPlayer(controlPanel.CONST_ABSpATH + "/Sounds/brrt.wav");

        public wrongForm()
        {
            InitializeComponent();
        }

        public gameForm gameForm = null;
        public string strXs;
        //create the form, but with two arguments:
        //callingForm: the parent form
        //Xs: amount of Xs to display
        public wrongForm(Form parentForm, string Xs)
        {
            gameForm = parentForm as gameForm;
            strXs = Xs;
            InitializeComponent();
        }


        private void wrongForm_Load(object sender, EventArgs e)
        {
            playerBrrt.Play();
            lblX.Text = strXs;
            //TODO: Insert "brrt" sound effect
            //Calls the wait function, which waits 1.5 seconds before closing
            waitFunction();
        }

        //Waits 1.5 seconds, then creates a task that closes
        public void waitFunction()
        {
            Task.Delay(TimeSpan.FromSeconds(2)).ContinueWith(t =>closeFunction());
        }

        //Closes the form
        public void closeFunction()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }
    }
}
