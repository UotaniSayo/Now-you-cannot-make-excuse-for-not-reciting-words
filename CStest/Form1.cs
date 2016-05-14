using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CStest
{
    public partial class main : Form
    {
        string[] tangoLine;
        int index=0;
        public main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //切换空间显示状态
            btnStart.Visible = false;
            btnFvrt.Visible = false;

            txtTango.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            btnHira.Visible = true;
            btnXplain.Visible = true;
            btnEnd.Visible = true;

            //index重置
            index = 0;


            int amount, track,i;
            amount = Convert.ToInt16(fillinAmount.Text);
            System.IO.StreamReader fileTrack = new System.IO.StreamReader(@"d:\tango\track.txt");
            System.IO.StreamReader fileTango = new System.IO.StreamReader(@"d:\tango\N2.csv");
            track = Convert.ToInt16(fileTrack.ReadLine());
            fileTrack.Close();
            amount = ((4386-track)>amount)?amount:4386-track;

            tangoLine = new string[amount];
            
            if (track != 1)
                for (i = 1; i <= track; i++)
                    fileTango.ReadLine();
            for (i = 0; i < amount; i++)
                tangoLine[i] = fileTango.ReadLine();
            fileTango.Close();
            txtTango.Text = tangoParse(tangoLine[0],1);
            txtHira.Text = tangoParse(tangoLine[0], 2);
            txtXplain.Text = tangoParse(tangoLine[0], 3);
        }

        private string tangoParse(string tango,int mode)
        //mode: 返回的内容
        //1返回单词本身
        //2返回单词读音
        //3返回单词释义
        {
            char[] delim = { ',' };
            string[] tangoSet = tango.Split(delim);
            switch (mode)
            {
                case (1):
                    if (tangoSet[2] == "")
                        return (tangoSet[1]);
                    else
                        return (tangoSet[2]);
                case (2):
                    return (tangoSet[1]);
                case (3):
                    return (tangoSet[3]);
                default:
                    return ("error");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                txtTango.Text = tangoParse(tangoLine[index], 1);
                txtHira.Text = tangoParse(tangoLine[index], 2);
                txtHira.Visible = false;
                txtXplain.Text = tangoParse(tangoLine[index], 3);
                txtXplain.Visible = false;
            }
                
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index<tangoLine.Length-1)
            {
                index++;
                txtTango.Text = tangoParse(tangoLine[index], 1);
                txtHira.Text = tangoParse(tangoLine[index], 2);
                txtHira.Visible = false;
                txtXplain.Text = tangoParse(tangoLine[index], 3);
                txtXplain.Visible = false;
                
            }
        }

        private void btnHira_Click(object sender, EventArgs e)
        {
            txtHira.Visible = true;
        }

        private void btnXplain_Click(object sender, EventArgs e)
        {
            txtXplain.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //切换空间显示状态
            btnStart.Visible = true;
            btnFvrt.Visible = true;

            txtTango.Visible = false;
            txtHira.Visible = false;
            txtXplain.Visible = false;
            btnPrev.Visible = false;
            btnNext.Visible = false;
            btnHira.Visible = false;
            btnXplain.Visible = false;
            btnEnd.Visible = false;

            //记录track
            int trackInt;
            string trackStr;
            
            System.IO.StreamReader fileTrack = new System.IO.StreamReader(@"d:\tango\track.txt");
            trackInt = Convert.ToInt16(fileTrack.ReadLine());
            fileTrack.Close();
            trackInt = trackInt + index + 1;
            trackStr = Convert.ToString(trackInt);
            System.IO.File.WriteAllText(@"d:\tango\track.txt", trackStr);
        }


    }
}
