using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitape_Turing_Machine_Sorting_Algorithm
{

    public partial class Turing_Machine : Form
    {
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public void setLabels(char[] inp, int i)
        {

            int j = 0;
            int lng = inp.Length;

            switch (i)
            {
                case 0:
                    {
                        if (j < lng)
                            l1.Text = Char.ToString(inp[j]);
                        else
                            l1.Text = "_";
                        j++;
                        if (j < lng)
                            l2.Text = Char.ToString(inp[j]);
                        else
                            l2.Text = "_";
                        j++;
                        if (j < lng)
                            l3.Text = Char.ToString(inp[j]);
                        else
                            l3.Text = "_";
                        j++;
                        if (j < lng)
                            l4.Text = Char.ToString(inp[j]);
                        else
                            l4.Text = "_";
                        j++;
                        if (j < lng)
                            l5.Text = Char.ToString(inp[j]);
                        else
                            l5.Text = "_";
                        j++;
                        if (j < lng)
                            l6.Text = Char.ToString(inp[j]);
                        else
                            l6.Text = "_";
                        j++;
                        if (j < lng)
                            l7.Text = Char.ToString(inp[j]);
                        else
                            l7.Text = "_";
                        j++;
                        if (j < lng)
                            l8.Text = Char.ToString(inp[j]);
                        else
                            l8.Text = "_";
                        j++;
                        if (j < lng)
                            l9.Text = Char.ToString(inp[j]);
                        else
                            l9.Text = "_";
                        j++;
                        if (j < lng)
                            l10.Text = Char.ToString(inp[j]);
                        else
                            l10.Text = "_";
                        j++;
                        if (j < lng)
                            l11.Text = Char.ToString(inp[j]);
                        else
                            l11.Text = "_";
                        j++;
                        if (j < lng)
                            l12.Text = Char.ToString(inp[j]);
                        else
                            l12.Text = "_";
                        j++;
                        if (j < lng)
                            l13.Text = Char.ToString(inp[j]);
                        else
                            l13.Text = "_";
                        j++;
                        if (j < lng)
                            l14.Text = Char.ToString(inp[j]);
                        else
                            l14.Text = "_";
                        j++;
                        if (j < lng)
                            l15.Text = Char.ToString(inp[j]);
                        else
                            l15.Text = "_";
                        j++;
                        if (j < lng)
                            l16.Text = Char.ToString(inp[j]);
                        else
                            l16.Text = "_";
                        j++;
                        if (j < lng)
                            l17.Text = Char.ToString(inp[j]);
                        else
                            l17.Text = "_";
                        j++;
                        if (j < lng)
                            l18.Text = Char.ToString(inp[j]);
                        else
                            l18.Text = "_";
                        j++;
                        if (j < lng)
                            l19.Text = Char.ToString(inp[j]);
                        else
                            l19.Text = "_";
                        j++;
                        if (j < lng)
                            l20.Text = Char.ToString(inp[j]);
                        else
                            l20.Text = "_";
                        j++;
                        break;
                    }
                case 1:
                    {
                        if (j < lng)
                            l1_1.Text = Char.ToString(inp[j]);
                        else
                            l1_1.Text = "_";
                        j++;
                        if (j < lng)
                            l2_1.Text = Char.ToString(inp[j]);
                        else
                            l2_1.Text = "_";
                        j++;
                        if (j < lng)
                            l3_1.Text = Char.ToString(inp[j]);
                        else
                            l3_1.Text = "_";
                        j++;
                        if (j < lng)
                            l4_1.Text = Char.ToString(inp[j]);
                        else
                            l4_1.Text = "_";
                        j++;
                        if (j < lng)
                            l5_1.Text = Char.ToString(inp[j]);
                        else
                            l5_1.Text = "_";
                        j++;
                        if (j < lng)
                            l6_1.Text = Char.ToString(inp[j]);
                        else
                            l6_1.Text = "_";
                        j++;
                        if (j < lng)
                            l7_1.Text = Char.ToString(inp[j]);
                        else
                            l7_1.Text = "_";
                        j++;
                        if (j < lng)
                            l8_1.Text = Char.ToString(inp[j]);
                        else
                            l8_1.Text = "_";
                        j++;
                        if (j < lng)
                            l9_1.Text = Char.ToString(inp[j]);
                        else
                            l9_1.Text = "_";
                        j++;
                        if (j < lng)
                            l10_1.Text = Char.ToString(inp[j]);
                        else
                            l10_1.Text = "_";
                        j++;
                        if (j < lng)
                            l11_1.Text = Char.ToString(inp[j]);
                        else
                            l11_1.Text = "_";
                        j++;
                        if (j < lng)
                            l12_1.Text = Char.ToString(inp[j]);
                        else
                            l12_1.Text = "_";
                        j++;
                        if (j < lng)
                            l13_1.Text = Char.ToString(inp[j]);
                        else
                            l13_1.Text = "_";
                        j++;
                        if (j < lng)
                            l14_1.Text = Char.ToString(inp[j]);
                        else
                            l14_1.Text = "_";
                        j++;
                        if (j < lng)
                            l15_1.Text = Char.ToString(inp[j]);
                        else
                            l15_1.Text = "_";
                        j++;
                        if (j < lng)
                            l16_1.Text = Char.ToString(inp[j]);
                        else
                            l16_1.Text = "_";
                        j++;
                        if (j < lng)
                            l17_1.Text = Char.ToString(inp[j]);
                        else
                            l17_1.Text = "_";
                        j++;
                        if (j < lng)
                            l18_1.Text = Char.ToString(inp[j]);
                        else
                            l18_1.Text = "_";
                        j++;
                        if (j < lng)
                            l19_1.Text = Char.ToString(inp[j]);
                        else
                            l19_1.Text = "_";
                        j++;
                        if (j < lng)
                            l20_1.Text = Char.ToString(inp[j]);
                        else
                            l20_1.Text = "_";
                        j++;
                        break;
                    }
                case 2:
                    {
                        if (j < lng)
                            l1_w.Text = Char.ToString(inp[j]);
                        else
                            l1_w.Text = "_";
                        j++;
                        if (j < lng)
                            l2_w.Text = Char.ToString(inp[j]);
                        else
                            l2_w.Text = "_";
                        j++;
                        if (j < lng)
                            l3_w.Text = Char.ToString(inp[j]);
                        else
                            l3_w.Text = "_";
                        j++;
                        if (j < lng)
                            l4_w.Text = Char.ToString(inp[j]);
                        else
                            l4_w.Text = "_";
                        j++;
                        if (j < lng)
                            l5_w.Text = Char.ToString(inp[j]);
                        else
                            l5_w.Text = "_";
                        j++;
                        if (j < lng)
                            l6_w.Text = Char.ToString(inp[j]);
                        else
                            l6_w.Text = "_";
                        j++;
                        if (j < lng)
                            l7_w.Text = Char.ToString(inp[j]);
                        else
                            l7_w.Text = "_";
                        j++;
                        if (j < lng)
                            l8_w.Text = Char.ToString(inp[j]);
                        else
                            l8_w.Text = "_";
                        j++;
                        if (j < lng)
                            l9_w.Text = Char.ToString(inp[j]);
                        else
                            l9_w.Text = "_";
                        j++;
                        if (j < lng)
                            l10_w.Text = Char.ToString(inp[j]);
                        else
                            l10_w.Text = "_";
                        j++;
                        if (j < lng)
                            l11_w.Text = Char.ToString(inp[j]);
                        else
                            l11_w.Text = "_";
                        j++;
                        if (j < lng)
                            l12_w.Text = Char.ToString(inp[j]);
                        else
                            l12_w.Text = "_";
                        j++;
                        if (j < lng)
                            l13_w.Text = Char.ToString(inp[j]);
                        else
                            l13_w.Text = "_";
                        j++;
                        if (j < lng)
                            l14_w.Text = Char.ToString(inp[j]);
                        else
                            l14_w.Text = "_";
                        j++;
                        if (j < lng)
                            l15_w.Text = Char.ToString(inp[j]);
                        else
                            l15_w.Text = "_";
                        j++;
                        if (j < lng)
                            l16_w.Text = Char.ToString(inp[j]);
                        else
                            l16_w.Text = "_";
                        j++;
                        if (j < lng)
                            l17_w.Text = Char.ToString(inp[j]);
                        else
                            l17_w.Text = "_";
                        j++;
                        if (j < lng)
                            l18_w.Text = Char.ToString(inp[j]);
                        else
                            l18_w.Text = "_";
                        j++;
                        if (j < lng)
                            l19_w.Text = Char.ToString(inp[j]);
                        else
                            l19_w.Text = "_";
                        j++;
                        if (j < lng)
                            l20_w.Text = Char.ToString(inp[j]);
                        else
                            l20_w.Text = "_";
                        j++;
                        break;
                    }
            }
        }
        public char[] moveLeft(char[] i, int x)
        {
            for (int k = 0; k < x; k++)
            {
                for (int j = 1; j < i.Length; j++)
                {
                    i[j - 1] = i[j];
                }
                i[i.Length - 1 -k] = '_';
            }
            return i;
        }
        public char[] moveRight(char[] i, int x)
        {
            for (int k = 0; k < x; k++)
            {
                for (int j = i.Length; j > 1; j--)
                {
                    i[j-1] = i[j - 2];
                }
                i[k] = '_';
            }
            
            return i;
        }
        public char[] moveLeftFrom(char[] i, int x)
        {
            for (int j = x; j < i.Length; j++)
                i[j - 1] = i[j];
            i[i.Length - 1] = '_';
            return i;
        }
        public char[] align(char[] i)
        {
            if(i[10]!='_')
            {
                i = moveLeft(i, 1);
            }
            int x = 0;
            for(int j=0;j<i.Length;j++)
            {
                if(i[j]!='_')
                {
                    x++;
                }
            }

            i = moveRight(i, x);
            return i;
        }
        public Turing_Machine()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool go = true;
            string inp = input.Text;
            if(inp.Length>10)
            {
                output.Text = "Wrong arguments! Only 0 and 1! 10 characters is maximum size!";
                go = false;
            }
            else
            for (int j = 0; j < inp.Length; j++)
            {
                    if (inp[j] == '0' || inp[j] == '1') ;
                    else
                {
                    output.Text = "Wrong arguments! Only 0 and 1! 10 characters is maximum size!";
                    go = false;
                }
            }
            if (go)
            {
                output.Text = "-";
                char[] in0 = new char[0];
                char[] in1 = new char[0];
                char[] inw = new char[0];
                setLabels(in0, 0);
                in0 = new char[inp.Length + 10];
                in1 = new char[inp.Length + 10];
                inw = new char[inp.Length + 10];
                for (int j = 0; j < inp.Length + 10; j++)
                {
                    if (j <= 9)
                    {
                        in0[j] = '_';
                    }
                    else
                        in0[j] = inp[j - 10];
                    in1[j] = '_';
                    inw[j] = '_';
                }
                setLabels(in0, 0);
                setLabels(in1, 1);
                setLabels(inw, 2);
                wait(500);              
                //
                for (int j = 10; j < in0.Length; j++)
                {
                    if (in0[10] == '0')
                    {
                        in0=moveLeft(in0, 1);
                        State.Text = "q1";
                    }
                    else
                    {
                        in1 = moveLeft(in1, 1);
                        in1[10] = in0[10];
                        in0 = moveLeftFrom(in0, 11);
                        State.Text = "q2";
                        
                    }
                    setLabels(in0, 0);
                    setLabels(in1, 1);
                    wait(500);

                }

                in0 = align(in0);
                in1 = align(in1);
                setLabels(in0, 0);
                setLabels(in1, 1);
                wait(500);
                
                for(int j=0;j<inp.Length;j++)
                {
                    if (in1[10] == '_') break;
                    State.Text = "q2";
                    inw = moveLeft(inw, 1);
                    inw[10] = in1[10];
                    in1[10] = '_';
                    in1 = moveLeft(in1, 1);
                    setLabels(in1, 1);
                    wait(250);
                    State.Text = "q3";
                    setLabels(inw, 2);
                    wait(250);
                }
                for (int j = 0; j < inp.Length; j++)
                {
                    if (in0[10] == '_') break;
                    State.Text = "q1";
                    inw = moveLeft(inw, 1);
                    inw[10] = in0[10];
                    in0[10] = '_';
                    in0 = moveLeft(in0, 1);
                    setLabels(in0, 0);
                    wait(250);
                    State.Text = "q3";
                    setLabels(inw, 2);
                    wait(250);

                }
                State.Text = "q4";
                string result = "";
                for(int j=0;j<inw.Length;j++)
                {
                    if (inw[j] != '_') 
                    result += inw[j];
                }
                output.Text = result;
            }

        }

        private void Turing_Machine_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
