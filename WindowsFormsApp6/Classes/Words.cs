using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6.Classes
{
    class Words : MainDatabase
    {

        UserWords uWords = new UserWords();
        
        Tools appTools = new Tools();
        public bool wordAdd(int userID, string tr, string en,string wordType)
        {
            bool addResult = false;
            try
            {
                mainConnect();
                MySqlCommand addWordCommand = new MySqlCommand("INSERT INTO words (user_id,tr_word,en_word,wordType) VALUES ('" + userID + "','" + tr + "','" + en + "','" + wordType + "')", mainDatabeseConn);
                addWordCommand.ExecuteNonQuery();
                addResult = true;
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }

            return addResult;

        }
        public bool wordDelete(int wordID)
        {
            bool deleteResult = false;
            try
            {
                mainConnect();
                MySqlCommand deleteWordCommand = new MySqlCommand("DELETE FROM words WHERE id=" + wordID, mainDatabeseConn);
                deleteWordCommand.ExecuteNonQuery();
                deleteResult = true;
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }

            return deleteResult;
        }
        

        public bool wordUpdate(int id, string tr, string en)
        {
            bool updateResult = false;
            try
            {
                mainConnect();
                MySqlCommand updateWordCommand = new MySqlCommand("UPDATE words SET tr_word='"+tr+"', en_word='"+en+"' WHERE id=" + id, mainDatabeseConn);
                updateWordCommand.ExecuteNonQuery();
                updateResult = true;
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }

            return updateResult;
        }
        public ListView wordSearch(string comingWord,int user_id)
        {
            ListView searchListView = new ListView();
            comingWord = "'%" + comingWord + "%'";
            int wordCount = 0;
            mainConnect();
            MySqlCommand searchWordCommand = new MySqlCommand("SELECT * from words WHERE en_word LIKE "+comingWord+ " or tr_word LIKE "+comingWord, mainDatabeseConn);
            MySqlDataReader wordReader = searchWordCommand.ExecuteReader();
            
                while (wordReader.Read())
                {
                    ListViewItem item = new ListViewItem(wordReader.GetString("id"));
                    item.SubItems.Add(wordReader.GetString("tr_word"));
                    item.SubItems.Add(wordReader.GetString("en_word"));
                    string username = appTools.userGetUserName(wordReader.GetString("user_id"));
                    item.SubItems.Add(username);
                    int level = uWords.userWordSearch(Convert.ToInt32(wordReader.GetString("id")), user_id);
                    if (level != 0)
                    {
                        item.SubItems.Add("Var");
                        item.SubItems.Add(level.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("Yok");
                        item.SubItems.Add("0");
                    }

                    searchListView.Items.Add(item);
                wordCount++;
                }
            if (wordCount==0)
            {
                searchListView = null;
            }

            mainConnect();
            return searchListView;
        }
        public ListView showWords(int user_id,int randomLimit)
        {
            ListView searchListView = new ListView();
            try
            {
                mainConnect();
                MySqlCommand showWordCommand = new MySqlCommand("SELECT * from words order by RAND() LIMIT " + randomLimit, mainDatabeseConn);
                MySqlDataReader wordReader = showWordCommand.ExecuteReader();
                while (wordReader.Read())
                {
                    ListViewItem item = new ListViewItem(wordReader.GetString("id"));
                    item.SubItems.Add(wordReader.GetString("tr_word"));
                    item.SubItems.Add(wordReader.GetString("en_word"));
                    string username = appTools.userGetUserName(wordReader.GetString("user_id"));
                    item.SubItems.Add(username);
                    int level = uWords.userWordSearch(Convert.ToInt32(wordReader.GetString("id")), user_id);
                    if (level != 0)
                    {
                        item.SubItems.Add("Var");
                        item.SubItems.Add(level.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("Yok");
                        item.SubItems.Add("0");
                    }

                    searchListView.Items.Add(item);
                }

                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }
            
            return searchListView;
        }

        public ListView myListSearch(List<int> wordsID,List<int> wordsLevel)
        {
            ListView searchListView = new ListView();

            
            for (int i = 0; i < wordsID.Count; i++)
            {
                
                try
                {
                    mainConnect();
                    MySqlCommand showWordCommand = new MySqlCommand("SELECT * from words WHERE id=" + wordsID[i], mainDatabeseConn);
                    MySqlDataReader wordReader = showWordCommand.ExecuteReader();
                    while (wordReader.Read())
                    {
                        ListViewItem item = new ListViewItem(wordReader.GetString("id"));
                        item.SubItems.Add(wordReader.GetString("tr_word"));
                        item.SubItems.Add(wordReader.GetString("en_word"));
                        string username = appTools.userGetUserName(wordReader.GetString("user_id"));
                        item.SubItems.Add(username);
                        item.SubItems.Add("Var");
                        item.SubItems.Add(wordsLevel[i].ToString());
                        searchListView.Items.Add(item);
                    }
                    mainConnect();
                }
                catch (Exception e)
                {
                    MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                    mainConnect();
                }


            }

            return searchListView;
        }

        public int getCountWords()
        {
            int count=0;
            try
            {
                mainConnect();
                DataSet datasetCount = new DataSet();
                MySqlDataAdapter getCountWordAdapter = new MySqlDataAdapter("SELECT * from words", mainDatabeseConn);
                getCountWordAdapter.Fill(datasetCount, "words");
                count = datasetCount.Tables["words"].Rows.Count;
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }
            return count;
        }

        public string[] getWord(int islem,int randID)
        {
            string[] word = new string[2];
            if (islem==1)
            {
                Random rnd = new Random();
                randID = rnd.Next(0, getCountWords());
            }
            
            try
            {
                int wordC = 0;
                mainConnect();
                MySqlCommand showWordCommand = new MySqlCommand("SELECT * from words WHERE id="+ randID , mainDatabeseConn);
                MySqlDataReader wordReader = showWordCommand.ExecuteReader();
                while(wordReader.Read())
                {
                    word[0] = wordReader.GetString("tr_word");
                    word[1] = wordReader.GetString("en_word");
                    wordC++;
                }
                if (wordC==0)
                {
                    getWord(1,1);
                }
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }

            return word;
        }

    }
}
