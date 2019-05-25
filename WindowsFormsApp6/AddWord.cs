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
    public partial class AddWord : UserControl
    {
        public AddWord()
        {
            InitializeComponent();
        }
        Classes.Words wordOperation = new Classes.Words();

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            if (trWordTextBox.Text!=null&& enWordTextBox!=null && wordTypeCombo!= null )
            {
                bool result = false;
                if (Classes.LoginUser.userlogin)
                {
                    result = wordOperation.wordAdd(Convert.ToInt32(Classes.LoginUser.userID), trWordTextBox.Text, enWordTextBox.Text, wordTypeCombo.Text);
                    if (result == true)
                    {
                        MessageBox.Show("Kelime başarıyla kayıt edildi.");
                    }
                }
                else
                {
                    MessageBox.Show("İşlem yapmadan önce lütfen giriş yapınız.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız");
            }
            
            
        }

        
    }
}
