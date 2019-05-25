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
    public partial class QuizPage : UserControl
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        Classes.UserWords userListWords = new Classes.UserWords();

        List<string> [] QuizList = new List<string>[4];
        List<string> wordsID = new List<string>();
        List<string> wordsLevel = new List<string>();
        List<string> wordsTR = new List<string>();
        List<string> wordsEN = new List<string>();
        int question = 0, options = 0;
        DateTime today = DateTime.Now;
        
      
        
        private void QuizPage_Load(object sender, EventArgs e)
        {
            
            QuizList = userListWords.QuizWords(Convert.ToInt32(Classes.LoginUser.userID));
            wordsID= QuizList[0];
            wordsLevel= QuizList[1];
            wordsTR= QuizList[2];
            wordsEN= QuizList[3];
            if (wordsID.Count!=0)
            {
                answerLoading();
            }
            else
            {
                MessageBox.Show("Bu gün çözebiliceğiniz soru bulunamadı");
                buttonEnabledFalse();
            }
        }

        public void answerLoading()
        {
            
            Random rnd = new Random();
            options = rnd.Next(0, 4);
            if (options==0)
            {
                aOptionsButton.ButtonText = wordsTR[question];
            }
            else if (options == 1)
            {
                bOptionsButton.ButtonText = wordsTR[question];
            }
            else if (options == 2)
            {
                cOptionsButton.ButtonText = wordsTR[question];
            }
            else if (options == 3)
            {
                dOptionsButton.ButtonText = wordsTR[question];
            }
            otherOptions();
            questionLabel.Text = wordsEN[question];
            levelLabel.Text = "Level= " + wordsLevel[question];

        }
        public void otherOptions()
        {
            Classes.Words WordOperation = new Classes.Words();
            string[] optionsWord = new string[2];
            if (options!=0)
            {
                optionsWord = WordOperation.getWord(1, 1);
                aOptionsButton.ButtonText = optionsWord[0];
            }
            if (options != 1)
            {
                optionsWord = WordOperation.getWord(1, 1);
                bOptionsButton.ButtonText = optionsWord[0];
            }
            if (options != 2)
            {
                optionsWord = WordOperation.getWord(1, 1);
                cOptionsButton.ButtonText = optionsWord[0];
            }
            if (options != 3)
            {
                optionsWord = WordOperation.getWord(1, 1);
                dOptionsButton.ButtonText = optionsWord[0];
            }

        }

        private void AOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(0);
        }

        private void BOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(1);
        }

        private void COptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(2);
        }

        private void DOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(3);
        }

        public void answerControl(int answer)
        {
            bool result=false;
            if (answer==options)
            {
                MessageBox.Show("Doğru Cevap");
                wordsLevel[question] = (Convert.ToInt32(wordsLevel[question])+1).ToString();
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
                wordsLevel[question] = 1.ToString();
            }
            result = userListWords.userWordUpdate(Convert.ToInt32(Classes.LoginUser.userID), Convert.ToInt32(wordsID[question]), Convert.ToInt32(wordsLevel[question]));

            if (result==true)
            {
                question++;
                if (question!=wordsID.Count)
                {
                    answerLoading();
                }
                else
                {
                    MessageBox.Show("Çözebileceğiniz başka soru kalmadı.");
                    buttonEnabledFalse();
                }
            }
            else
            {
                MessageBox.Show("Cevabınız kayıt edilirken sorun oluştu.");
            }
        }

        void buttonEnabledFalse()
        {
            aOptionsButton.Enabled = false;
            bOptionsButton.Enabled = false;
            cOptionsButton.Enabled = false;
            dOptionsButton.Enabled = false;
        }
    }
}
