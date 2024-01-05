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
    public partial class gameForm : Form
    {
        public string lblOneText
        {
            get { return lblOne.Text; }
            set { lblOne.Text = value; }
        }

        public string lblTwoText
        {
            get { return lblTwo.Text; }
            set { lblTwo.Text = value; }
        }

        public string lblThreeText
        {
            get { return lblThree.Text; }
            set { lblThree.Text = value; }
        }

        public string lblFourText
        {
            get { return lblFour.Text; }
            set { lblFour.Text = value; }
        }

        public string lblFiveText
        {
            get { return lblFive.Text; }
            set { lblFive.Text = value; }
        }

        public string lblSixText
        {
            get { return lblSix.Text; }
            set { lblSix.Text = value; }
        }

        public string lblSevenText
        {
            get { return lblSeven.Text; }
            set { lblSeven.Text = value; }
        }

        public string lblEightText
        {
            get { return lblEight.Text; }
            set { lblEight.Text = value; }
        }

        public gameForm()
        {
            InitializeComponent();
        }

        public void wrongAnswer(string Xs)
        {
            wrongForm wrongForm = new wrongForm(this, Xs);
            wrongForm.Show();
        }

        public controlPanel controlPanel = null;
        public string strSelectedPrompt;
        //create the form, but with two arguments:
        //callingForm: the parent form
        //selectedPrompt: which file should be opened
        public gameForm(Form callingForm, string selectedPrompt)
        {
            controlPanel = callingForm as controlPanel;
            strSelectedPrompt = selectedPrompt;
            InitializeComponent();
        }

        //on load, immediately open up the admin panel as a child
        //this should, in theory, let the admin panel alter the labels on the game form
        private void gameForm_Load(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel(this, strSelectedPrompt);
            adminPanel.Show();
        }
    }
}
