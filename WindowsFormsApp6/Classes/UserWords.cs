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
    class UserWords : UserWordsDatabase
    {

        public bool userWordTableCreate(int id)
        {
            bool tableCreateResult = false;
            string tableName = "Words_" + id;
            try
            {
                userWordConnect();
                MySqlCommand tableCreateCommand = new MySqlCommand("CREATE TABLE " + tableName + "(id INT PRIMARY KEY AUTO_INCREMENT, word_id VARCHAR(11),level INT,first_date Date) ", userWordConnection);
                tableCreateCommand.ExecuteNonQuery();
                tableCreateResult = true;
                userWordConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                userWordConnect();
            }


            return tableCreateResult;
        }

        public bool userWordAdd(int userID, int wordID)
        {
            bool addResult = false;
            try
            {
                userWordConnect();
                DateTime getTime = DateTime.Now;
                string time = getTime.Year + "." + getTime.Month + "." + getTime.Day;
                MySqlCommand addWordCommand = new MySqlCommand("INSERT INTO words_" + userID + " (word_id,level,first_date) VALUES ('" + wordID + "','" + 1 + "','" + time + "')", userWordConnection);
                addWordCommand.ExecuteNonQuery();
                addResult = true;
                userWordConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }

            return addResult;
        }

        public bool userWordUpdate(int userID, int wordID, int level)
        {
            bool addResult = false;
            try
            {
                userWordConnect();
                DateTime getTime = DateTime.Now;
                string time = getTime.Year + "." + getTime.Month + "." + getTime.Day;
                MySqlCommand updateWordCommand = new MySqlCommand("UPDATE words_" + userID + " SET level='" + level + "', first_date='" + time + "' WHERE word_id=" + wordID, userWordConnection);
                updateWordCommand.ExecuteNonQuery();
                addResult = true;
                userWordConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }

            return addResult;
        }
        public bool userWordDelete(int userID, int wordID)
        {
            bool deleteResult = false;
            try
            {
                userWordConnect();
                MySqlCommand deleteWordCommand = new MySqlCommand("DELETE FROM words_" + userID + " WHERE word_id=" + wordID, userWordConnection);
                deleteWordCommand.ExecuteNonQuery();
                deleteResult = true;
                userWordConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }

            return deleteResult;
        }
        public int userWordSearch(int wordID, int userID)
        {
            int wordLevel = 0;
            try
            {
                userWordConnect();
                MySqlCommand uWSearchCommand = new MySqlCommand("Select * from words_" + userID + " WHERE word_id=" + wordID, userWordConnection);
                MySqlDataReader reader = uWSearchCommand.ExecuteReader();
                while (reader.Read())
                {
                    wordLevel = Convert.ToInt32(reader.GetString("level"));
                }
                userWordConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }

            return wordLevel;
        }

        public int statistic(int userID)
        {
            int learnedWordsStatic = 0;
            try
            {
                int learnedWord = 0, words = 0;
                userWordConnect();
                MySqlCommand listUserWordsCommand = new MySqlCommand("Select * from words_" + userID + " ORDER BY first_date ASC", userWordConnection);
                MySqlDataReader reader = listUserWordsCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32("level") == 6)
                    {
                        learnedWord++;
                    }
                    words++;
                }

                if (learnedWord != 0)
                {
                    learnedWordsStatic = (learnedWord * 100) / words;
                }
                else
                {
                    learnedWordsStatic = 0;
                }

                userWordConnect();

            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }
            return learnedWordsStatic;
        }

        public ListView listUserWords(int userID)
        {
            ListView myWords = new ListView();
            List<int> myWordsLevel = new List<int>();
            List<int> myWordsID = new List<int>();
            try
            {
                userWordConnect();
                MySqlCommand listUserWordsCommand = new MySqlCommand("Select * from words_" + userID + " ORDER BY first_date ASC", userWordConnection);
                MySqlDataReader reader = listUserWordsCommand.ExecuteReader();
                while (reader.Read())
                {
                    myWordsID.Add(reader.GetInt32("word_id"));
                    myWordsLevel.Add(reader.GetInt32("level"));
                }
                userWordConnect();
                if (myWordsID.Count != 0)
                {
                    Words wrds = new Words();
                    myWords = wrds.myListSearch(myWordsID, myWordsLevel);
                }
                else
                {
                    myWords = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }


            return myWords;
        }

        public List<string>[] QuizWords(int userID)
        {
            Words wrds = new Words();
            List<string>[] myWords = new List<string>[4];
            List<string> wordsID = new List<string>();
            List<string> wordsLevel = new List<string>();
            List<string> wordsTR = new List<string>();
            List<string> wordsEN = new List<string>();
            try
            {
                userWordConnect();
                MySqlCommand listUserWordsCommand = new MySqlCommand("Select * from words_" + userID + " ORDER BY first_date ASC", userWordConnection);
                MySqlDataReader reader = listUserWordsCommand.ExecuteReader();
                while (reader.Read())
                {

                    int getLevelDay = levelDay(reader.GetInt32("level"));
                    if ((reader.GetDateTime("first_date") <= DateTime.Now) && reader.GetInt32("level") < 6)
                    {
                        TimeSpan extraction = reader.GetDateTime("first_date") - DateTime.Now;
                        string extractionDay = extraction.Duration().Days.ToString();
                        int convertDay = ((-1) * Convert.ToInt32(extractionDay)) + getLevelDay;
                        if (convertDay <= 0)
                        {
                            wordsID.Add(reader.GetString("word_id"));
                            wordsLevel.Add(reader.GetString("level"));
                            string[] getWord = wrds.getWord(0, reader.GetInt32("word_id"));
                            wordsTR.Add(getWord[0]);
                            wordsEN.Add(getWord[1]);
                        }
                    }
                }
                userWordConnect();

                myWords[0] = wordsID;
                myWords[1] = wordsLevel;
                myWords[2] = wordsTR;
                myWords[3] = wordsEN;
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }

            return myWords;
        }

        public int levelDay(int level)
        {
            int day = 0; ;
            if (level == 1)
            {
                day = 1;
            }
            if (level == 2)
            {
                day = 3;
            }
            if (level == 3)
            {
                day = 10;
            }
            if (level == 4)
            {
                day = 30;
            }
            if (level == 5)
            {
                day = 60;
            }
            return day;
        }



        public ListView statisticList(int userID)
        {
            ListView myWords = new ListView();
            try
            {
                userWordConnect();
                MySqlCommand listUserWordsCommand = new MySqlCommand("Select * from words_" + userID + " ORDER BY first_date ASC", userWordConnection);
                MySqlDataReader reader = listUserWordsCommand.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString("level"));
                    item.SubItems.Add(reader.GetString("first_date"));
                    myWords.Items.Add(item);
                }
                userWordConnect();

            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                userWordConnect();
            }
            return myWords;
        }

    }
}
