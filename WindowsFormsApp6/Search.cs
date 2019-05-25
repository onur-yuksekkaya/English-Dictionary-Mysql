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
    public partial class Search : UserControl
    {
        Classes.Tools ts = new Classes.Tools();
        int myListType = 0;

        public Search()
        {
            InitializeComponent();
        }


        Classes.Words wordsOperations = new Classes.Words();
        Classes.UserWords userWordsOperations = new Classes.UserWords();


        private void Search_Load(object sender, EventArgs e)
        {
            randomList();
            
        }

        
      

        private void SearchButton_Click(object sender, EventArgs e)
        {   ListView searchResult = new ListView();
            searchResult = wordsOperations.wordSearch(searchText.Text,Convert.ToInt32(Classes.LoginUser.userID));

            try
            {
                wordList(searchResult, searchResult.Items.Count);
            }
            catch (Exception)
            {
                MessageBox.Show("Aradığınız kelime bulunamadı.");
            }

          
            
        }

        void randomList()
        {
            ListView searchResult = new ListView();
            searchResult = wordsOperations.showWords(Convert.ToInt32(Classes.LoginUser.userID),100);
            wordList(searchResult, searchResult.Items.Count);
        }
        void wordList(ListView listListview, int itemCount)
        {
            searchListView.Items.Clear();
            for (int i = 0; i < itemCount; i++)
            {
                ListViewItem item = new ListViewItem(listListview.Items[i].SubItems[0].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[1].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[2].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[3].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[4].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[5].Text);
                searchListView.Items.Add(item);

            }
        }

        private void RandomButton_Click(object sender, EventArgs e) { myListType = 0; randomList(); }

        private void MyListButton_Click(object sender, EventArgs e)
        {
            ListView searchResult = new ListView();
            searchResult = userWordsOperations.listUserWords(Convert.ToInt32(Classes.LoginUser.userID));
            if (searchResult!=null)
            {
                wordList(searchResult, searchResult.Items.Count);
                myListType = 1;
            }
            else
            {
                MessageBox.Show("Listenizde hiç kelime yer almamaktadır.");
            }
            
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {

            bool result = false; string state = null, level = null;
            if (searchListView.SelectedItems.Count==1)
            {
                
                if (addListButton.ButtonText == "Listeme Ekle")
                {
                   result= userWordsOperations.userWordAdd(Convert.ToInt32(Classes.LoginUser.userID), Convert.ToInt32(searchListView.SelectedItems[0].Text));
                    if (result==true)
                    {
                        state = "Var"; level = "1";
                        addListButton.ButtonText = "Listeme ...";
                    }
                   
                }
                else if (addListButton.ButtonText == "Listemden Çıkar")
                {
                    result = userWordsOperations.userWordDelete(Convert.ToInt32(Classes.LoginUser.userID), Convert.ToInt32(searchListView.SelectedItems[0].Text));
                    if (result == true)
                    {
                        state = "Yok"; level = "0";
                        addListButton.ButtonText = "Listeme ...";
                        if (myListType==1)
                        {
                            searchListView.Items.RemoveAt(searchListView.SelectedItems[0].Index);
                        }       
                    }
                }
                else if (addListButton.ButtonText == "Listeme ...")
                {
                    MessageBox.Show("Listenize kelime eklemek veya çıkarmak için lütfen bir kelime seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Listenize kelime eklemek veya çıkarmak için lütfen bir kelime seçiniz.");
            }

            if (result==true)
            {
                if (myListType==0)
                {
                    searchListView.SelectedItems[0].SubItems[4].Text = state;
                    searchListView.SelectedItems[0].SubItems[5].Text = level;
                }
                MessageBox.Show("İşleminiz başarıyla gerçekleşti");
            }
            
        }

        private void SearchListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchListView.SelectedItems.Count>0)
            {
                if (searchListView.SelectedItems[0].SubItems[4].Text=="Var")
                {
                    addListButton.ButtonText = "Listemden Çıkar";
                }
                else if (searchListView.SelectedItems[0].SubItems[4].Text == "Yok")
                {
                    addListButton.ButtonText = "Listeme Ekle"; 
                }
            }
        }

        private void DeleteWordButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (searchListView.SelectedItems.Count ==1)
            {
                if (searchListView.SelectedItems[0].SubItems[3].Text == Classes.LoginUser.userName)
                {
                    result = wordsOperations.wordDelete(Convert.ToInt32(searchListView.SelectedItems[0].Text));
                }
                else
                {
                    MessageBox.Show("Size ait olmayan kelimeleri silemezsiniz.");
                }
            }

            if (result == true)
            {
                MessageBox.Show("İşleminiz başarıyla gerçekleşti");
                searchListView.Items.RemoveAt(searchListView.SelectedItems[0].Index);
            }

        }

        private void UpdateWordButton_Click(object sender, EventArgs e)
        {
           
            if (searchListView.SelectedItems.Count == 1)
            {
                if (searchListView.SelectedItems[0].SubItems[3].Text == Classes.LoginUser.userName)
                {
                    wordIDLabel.Text = searchListView.SelectedItems[0].Text;
                    enWordTextBox.Text = searchListView.SelectedItems[0].SubItems[2].Text;
                    trWordTextBox.Text = searchListView.SelectedItems[0].SubItems[1].Text;
                    updatePanel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Size ait olmayan kelimeleri güncelleyemezsiniz.");
                }
            }

            
        }

        private void AddWordPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("AddWord");
        }

        private void UpdateCloseButton_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
        }

        private void UpdateWordButton2_Click(object sender, EventArgs e)
        {
            bool result = false;
            result = wordsOperations.wordUpdate(Convert.ToInt32(wordIDLabel.Text), trWordTextBox.Text, enWordTextBox.Text);
            if (result == true)
            {
                MessageBox.Show("İşleminiz başarıyla gerçekleşti");
                searchListView.SelectedItems[0].SubItems[1].Text = trWordTextBox.Text;
                searchListView.SelectedItems[0].SubItems[2].Text = enWordTextBox.Text;
                updatePanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Güncelleme sırasında bir sorun oluştu");
            }
        }
    }
}
