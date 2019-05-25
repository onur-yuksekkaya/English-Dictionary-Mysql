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
    public partial class TabSignUp : UserControl
    {
        public TabSignUp()
        {
            InitializeComponent();
            


        }

      

        int placeHolderCounter = 0;
        private void PassText_OnValueChanged(object sender, EventArgs e)
        {
            if (placeHolderCounter == 0)
            {
                passText.Text = "";
                placeHolderCounter++;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Classes.Register register = new Classes.Register();
            int registerResult = register.userRegister(nameText.Text, userNameText.Text, mailText.Text, passText.Text);

            if (registerResult == 1)
            {
                MessageBox.Show("Başarıyla kayıt oldunuz !");
            }
            else if (registerResult == 3)
            {
                MessageBox.Show("Daha önce kayıt olmuşsunuz");
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir sıkıntı oluştu");
            }
        }

        private void TabSignPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("TabSign"); 
        }
    }
}
