using System;
using System.IO;
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
    public partial class controlPanel : Form
    {
        public const string CONST_ABSpATH = "C:/Users/Avery/source/repos/familyFeud/familyFeud"; //direct path to the root folder. Adjust as needed!
        private DirectoryInfo dir = new DirectoryInfo(CONST_ABSpATH + "/Prompts"); //directory info for the "Prompts" folder. Used for reading file names
        public string strSelectedPrompt; //str for selected prompt
        public controlPanel()
        {
            InitializeComponent();
        }

        //On load, get all the available files and display them in lstPrompts
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FileInfo fileInfo in dir.GetFiles())
            {
                lstPrompts.Items.Add(fileInfo.Name);
            }
        }

        public void btnOpen_Click(object sender, EventArgs e) 
        {
            strSelectedPrompt = lstPrompts.SelectedItem.ToString(); //store current selected prompt as string
            gameForm gameForm = new gameForm(this, strSelectedPrompt);
            gameForm.Show();
        
        }
    }
}
