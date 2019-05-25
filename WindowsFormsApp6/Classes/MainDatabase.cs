using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6.Classes
{
    class MainDatabase
    {
        protected MySqlConnection mainDatabeseConn = new MySqlConnection("Server=localhost;Database=english_app;Uid=root;Pwd='';");


        public void mainConnect()
        {
            try
            {
                if (mainDatabeseConn.State == ConnectionState.Closed)
                {
                    mainDatabeseConn.Open();
                }
                else
                {
                    mainDatabeseConn.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata  " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
