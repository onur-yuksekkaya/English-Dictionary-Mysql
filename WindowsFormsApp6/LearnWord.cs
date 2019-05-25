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
    public partial class LearnWord : UserControl
    {
        Classes.Words appWords = new Classes.Words();
        List<string> trWords = new List<string>();
        List<string> enWords = new List<string>();
        int queue = 0;

        public LearnWord()
        {
            

            InitializeComponent();
        }


        private void LearnWord_Load(object sender, EventArgs e)
        {
            getWords();
            enWordLabel.Text = enWords[queue];
            trWordLabel.Text = trWords[queue];
            Classes.UserWords userWord = new Classes.UserWords();
            int learnedStatistic = userWord.statistic(Convert.ToInt32(Classes.LoginUser.userID));
            statisticBar.Value = learnedStatistic;
        }

        void getWords()
        {
            string[] words = new string[2];
            words = appWords.getWord(1,1);
            trWords.Add(words[0]);
            enWords.Add(words[1]);
        }

        private void PreviousWordButton_Click(object sender, EventArgs e)
        {
            if (queue ==0)
            {
                MessageBox.Show("Öğrenmeye yeni başlamışsınız. Geri gidemezsiniz.");
            }
            if (queue>0)
            {
                queue--;
                enWordLabel.Text= enWords[queue];
                trWordLabel.Text = trWords[queue];
                trWordLabel.Visible = false;
            }
        }

        private void ShowWordButton_Click(object sender, EventArgs e)
        {
            trWordLabel.Visible = true;
        }

        private void NextWordButton_Click(object sender, EventArgs e)
        {
            queue++;
            if (queue == trWords.Count)
            {
                getWords();
            }
            enWordLabel.Text = enWords[queue];
            trWordLabel.Text = trWords[queue];
            trWordLabel.Visible = false;
        }

        private void QuizPageButton_Click(object sender, EventArgs e)
        {
           
            Classes.Tools.pageDirects("QuizPage");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
