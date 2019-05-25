using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6.Classes
{
    class Login:MainDatabase
    {
        public string[] userLogin(string userName, string pass)
        {
            string[] user = new string[3];
            try
            {
               
                Tools appTool = new Tools();
                pass = appTool.MD5Convert(pass);
                int userLoginCount = 0;
                mainConnect();
                MySqlCommand userLoginCommand = new MySqlCommand("SELECT * from users WHERE username='" + userName + "' ", mainDatabeseConn);
                MySqlDataReader reader = userLoginCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString("pass") == pass)
                    {

                        user[0] = reader.GetString("id");
                        user[1] = reader.GetString("name");
                        user[2] = reader.GetString("username");
                    }
                    else
                    {
                        user[0] = "PAROLA_HATASI";
                    }
                    userLoginCount++;
                }

                if (userLoginCount != 1)
                {
                    user = null;
                }

                mainConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                mainConnect();
            }
            
            return user;
        }
    }
}
