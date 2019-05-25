using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelMain; }
            set { panelMain = null; }
        }

        public Form1()
        {    
            InitializeComponent();
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BunifuImageButton3_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void BunifuImageButton4_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

       

        private void BunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void BunifuImageButton4_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            Classes.Tools.pageDirects("TabSign");
            loginTimer.Start();

        }

        private void MainBaseButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("MainBase");
        }

        private void TabSignUpButton_Click(object sender, EventArgs e)
        {
             Classes.Tools.pageDirects("TabSignUp");
        }

        private void SearchPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("Search");
        }

        private void AddWordPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("AddWord");
        }

        private void LearnWordPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("LearnWord");
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            if (Classes.LoginUser.userID == null)
            {
                bunifuGradientPanel2.Visible = false;
            }
            else
            {
                bunifuGradientPanel2.Visible = true;
                
                loginTimer.Stop();
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("Statistics");
        }

        private void BunifuImageButton2_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void BunifuImageButton2_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
 }

