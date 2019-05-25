using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class TabSign : UserControl
    {
        public TabSign()
        {
            InitializeComponent();
        }
        
        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Classes.Login lgn = new Classes.Login();
            
            
            string[] user = lgn.userLogin(userNameText.Text, passText.Text);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            else if (user[0] == "PAROLA_HATASI")
            {
                MessageBox.Show("Parolanızı yanlış girdiniz.");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                Classes.LoginUser.userlogin = true;
                Classes.LoginUser.userID = user[0];
                Classes.LoginUser.userRealName = user[1];
                Classes.LoginUser.userName = user[2];
                Classes.Tools.pageDirects("Statistics");
                

            }


        }

        
        private void PassText_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TabSign_Load(object sender, EventArgs e)
        {
           
        }

        private void TabSignUpPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("TabSignUp");
        }
    }
}
