using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace familyFeud
{
    public partial class adminPanel : Form
    {
        public System.Media.SoundPlayer playerDing = new System.Media.SoundPlayer(controlPanel.CONST_ABSpATH + "/Sounds/ding.wav");

        //object that stores the JSON file info
        public class Game
        {
            public string prompt { get; set; }
            public string one { get; set; }
            public string two { get; set; }
            public string three { get; set; }
            public string four { get; set; }
            public string five { get; set; }
            public string six { get; set; }
            public string seven { get; set; }
            public string eight { get; set; }
        }



        public adminPanel()
        {
            InitializeComponent();
        }

        public gameForm gameFORM = null;
        public string strSelectedPrompt;
        //create the form, but with two arguments:
        //callingForm: the parent form
        //selectedPrompt: which file should be opened
        public adminPanel(Form gameForm, string selectedPrompt)
        {
            gameFORM = gameForm as gameForm;
            strSelectedPrompt = selectedPrompt;
            InitializeComponent();
        }

        //function for setting up the game board
        //just to make the code a little prettier
        private void gameSetUp(Game gameInfo)
        {
            lblPrompt.Text = gameInfo.prompt;
            btnOne.Text = gameInfo.one;
            btnTwo.Text = gameInfo.two;
            btnThree.Text = gameInfo.three;
            btnFour.Text = gameInfo.four;
            btnFive.Text = gameInfo.five;
            btnSix.Text = gameInfo.six;
            btnSeven.Text = gameInfo.seven;
            btnEight.Text = gameInfo.eight;
        }

        //on load, set up the form as it should appear.
        //place the prompt near the top
        //place the titles of each as a button
        private void adminPanel_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText(controlPanel.CONST_ABSpATH + "/Prompts/" + strSelectedPrompt))
            {
                JsonSerializer serializer = new JsonSerializer();
                Game gameInfo = (Game)serializer.Deserialize(file, typeof(Game));

                gameSetUp(gameInfo);
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblOneText = btnOne.Text;
            playerDing.Play();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblTwoText = btnTwo.Text;
            playerDing.Play();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblThreeText = btnThree.Text;
            playerDing.Play();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblFourText = btnFour.Text;
            playerDing.Play();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblFiveText = btnFive.Text;
            playerDing.Play();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblSixText = btnSix.Text;
            playerDing.Play();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblSevenText = btnSeven.Text;
            playerDing.Play();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.gameFORM.lblEightText = btnEight.Text;
            playerDing.Play();
        }

        private void btnOneX_Click(object sender, EventArgs e)
        {
            this.gameFORM.wrongAnswer("X");
        }

        private void btnTwoX_Click(object sender, EventArgs e)
        {
            this.gameFORM.wrongAnswer("XX");
        }

        private void btnThreeX_Click(object sender, EventArgs e)
        {
            this.gameFORM.wrongAnswer("XXX");
        }
    }
}
