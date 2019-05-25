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
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }
        Classes.UserWords userWord = new Classes.UserWords();
        int level1 = 0, level2 = 0, level3 = 0, level4 = 0, level5 = 0, level6 = 0;
        int ay1 = 0, ay2 = 0, ay3 = 0, ay4 = 0, ay5 = 0, ay6 = 0, ay7 = 0, ay8 = 0, ay9 = 0, ay10 = 0, ay11 = 0, ay12 = 0;

        ListView statistic = new ListView();
        private void Statistics_Load(object sender, EventArgs e)
        {
            statistic = userWord.statisticList(Convert.ToInt32(Classes.LoginUser.userID));
            statistics_();
        }
        public void statistics_()
        {
            for (int i = 0; i < statistic.Items.Count; i++)
            {
                DateTime time= Convert.ToDateTime(statistic.Items[i].SubItems[1].Text);
                int ay = time.Month;

                level(Convert.ToInt32(statistic.Items[i].SubItems[0].Text));
                aylar(ay);
            }

            chart1.Series["Level"].Points.AddXY("1", level1);
            chart1.Series["Level"].Points.AddXY("2", level2);
            chart1.Series["Level"].Points.AddXY("3", level3);
            chart1.Series["Level"].Points.AddXY("4", level4);
            chart1.Series["Level"].Points.AddXY("5", level5);
            chart1.Series["Level"].Points.AddXY("6", level6);

            chart2.Series["Aylar"].Points.AddXY("Ocak", ay1);
            chart2.Series["Aylar"].Points.AddXY("Şubat", ay2);
            chart2.Series["Aylar"].Points.AddXY("Mart", ay3);
            chart2.Series["Aylar"].Points.AddXY("Nisan", ay4);
            chart2.Series["Aylar"].Points.AddXY("Mayıs", ay5);
            chart2.Series["Aylar"].Points.AddXY("Haziran", ay6);
            chart2.Series["Aylar"].Points.AddXY("Temmuz", ay7);
            chart2.Series["Aylar"].Points.AddXY("Ağustos", ay8);
            chart2.Series["Aylar"].Points.AddXY("Eylül", ay9);
            chart2.Series["Aylar"].Points.AddXY("Ekim", ay10);
            chart2.Series["Aylar"].Points.AddXY("Kasım", ay11);
            chart2.Series["Aylar"].Points.AddXY("Aralık", ay12);



        }


        void level(int level)
        {
            if (level == 1)
            {
                level1++;
            }
            else if (level == 2)
            {
                level2++;
            }
            else if (level == 3)
            {
                level3++;
            }
            else if (level == 4)
            {
                level4++;
            }
            else if (level == 5)
            {
                level5++;
            }
            else if (level == 6)
            {
                level6++;
            }
        }

        void aylar(int ay)
        {
            if (ay == 1)
            {
                ay1++;
            }
            else if (ay == 2)
            {
                ay2++;
            }
            else if (ay == 3)
            {
                ay3++;
            }
            else if (ay == 4)
            {
                ay4++;
            }
            else if (ay == 5)
            {
                ay5++;
            }
            else if (ay == 6)
            {
                ay6++;
            }
            else if (ay == 7)
            {
                ay7++;
            }
            else if (ay == 8)
            {
                ay8++;
            }
            else if (ay == 9)
            {
                ay9++;
            }
            else if (ay == 10)
            {
                ay10++;
            }
            else if (ay == 11)
            {
                ay11++;
            }
            else if (ay == 12)
            {
                ay12++;
            }

        }
    }
}
