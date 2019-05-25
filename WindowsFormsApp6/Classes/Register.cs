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
    class Register : MainDatabase
    {
        public int userRegister(string name, string userName, string email, string pass)
        {
            int registerResult = 0;
            if (userController(userName, email))
            {
                Tools appTools = new Tools();
                pass = appTools.MD5Convert(pass);
                try
                {
                    mainConnect();
                    MySqlCommand registerCommand = new MySqlCommand("INSERT INTO users (name,username,email,pass) VALUES ('" + name + "','" + userName + "','" + email + "','" + pass + "')", mainDatabeseConn);
                    registerCommand.ExecuteNonQuery();
                    mainConnect();
                    registerResult = 1;
                    UserWords userword = new UserWords();
                    int id = appTools.userGetID(userName);
                    userword.userWordTableCreate(id);
                }
                catch (Exception)
                {
                    MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                    mainConnect();
                }
            }
            else
            {
                registerResult = 3;
            }
            return registerResult;
        }

        public bool userController(string userName, string email)
        {
            int userCount = 0;
            bool userControlResult = true;
            try
            {
                mainConnect();
                MySqlCommand userControlCommand = new MySqlCommand("SELECT * from users WHERE username='" + userName + "' OR email= '" + email + "' ", mainDatabeseConn);
                userCount = Convert.ToInt32(userControlCommand.ExecuteScalar());
                if (userCount > 0)
                {
                    userControlResult = false;
                }
                mainConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                mainConnect();
            }
            
            
            return userControlResult;
        }






    }
}
