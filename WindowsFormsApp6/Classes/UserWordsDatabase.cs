using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6.Classes
{
    class UserWordsDatabase
    {
        protected MySqlConnection userWordConnection = new MySqlConnection("Server=localhost;Database=user_word;Uid=root;Pwd='';");

        public void userWordConnect()
        {
            try
            {
                if (userWordConnection.State == ConnectionState.Closed)
                {
                    userWordConnection.Open();
                }
                else
                {
                    userWordConnection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata  " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
