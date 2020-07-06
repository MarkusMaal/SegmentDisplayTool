using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segment_tool
{
    public partial class Form1 : Form
    {
        int[] segments = new int[7];
        bool flt = false;
        bool fb = true;
        bool iflt = true;
        string separate = "";
        Color preactivecolor = Color.Black;
        Color activecolor = Color.Black;
        Color restorecolor = Color.FromArgb(147, 186, 99);
        //Color bg = Color.FromArgb(167, 206, 119);
        public Form1()
        {
            InitializeComponent();
        }

        private void Segment1_Click(object sender, EventArgs e)
        {
            if (Segment1.BackColor == restorecolor)
            {
                segments[0] = 1;
                Segment1.BackColor = activecolor;
                return;
            }
            else
            {
                segments[0] = 0;
                Segment1.BackColor = restorecolor;
                return;
            }
        }

        private void Segment2_Click(object sender, EventArgs e)
        {
            if (Segment2.BackColor == restorecolor)
            {
                segments[1] = 1;
                Segment2.BackColor = activecolor;
                return;
            }
            else
            {
                segments[1] = 0;
                Segment2.BackColor = restorecolor;
                return;
            }
        }

        private void Segment3_Click(object sender, EventArgs e)
        {
            if (Segment3.BackColor == restorecolor)
            {
                segments[2] = 1;
                Segment3.BackColor = activecolor;
                return;
            }
            else
            {
                segments[2] = 0;
                Segment3.BackColor = restorecolor;
                return;
            }
        }

        private void Segment4_Click(object sender, EventArgs e)
        {
            if (Segment4.BackColor == restorecolor)
            {
                segments[3] = 1;
                Segment4.BackColor = activecolor;
                return;
            }
            else
            {
                segments[3] = 0;
                Segment4.BackColor = restorecolor;
                return;
            }
        }

        private void Segment5_Click(object sender, EventArgs e)
        {
            if (Segment5.BackColor == restorecolor)
            {
                segments[4] = 1;
                Segment5.BackColor = activecolor;
                return;
            }
            else
            {
                segments[4] = 0;
                Segment5.BackColor = restorecolor;
                return;
            }
        }

        private void Segment6_Click(object sender, EventArgs e)
        {
            if (Segment6.BackColor == restorecolor)
            {
                segments[5] = 1;
                Segment6.BackColor = activecolor;
                return;
            }
            else
            {
                segments[5] = 0;
                Segment6.BackColor = restorecolor;
                return;
            }
        }

        private void Segment7_Click(object sender, EventArgs e)
        {
            if (Segment7.BackColor == restorecolor)
            {
                segments[6] = 1;
                Segment7.BackColor = activecolor;
                return;
            }
            else
            {
                segments[6] = 0;
                Segment7.BackColor = restorecolor;
                return;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            for (int i = 0; i < 7; i++ )
            {
                segments[i] = 0;
            }
            
        }

        private void SegmentChecker_Tick(object sender, EventArgs e)
        {
            OutPutLabel.Text = "";
            for (int i = 0; i < 7; i++)
            {
                OutPutLabel.Text = OutPutLabel.Text + segments[i].ToString() + separate;
            }
            if (iflt == true)
            {
                if (fb == true)
                {
                    OutPutLabel.Text = Convert.ToInt32(flt).ToString() + separate +  OutPutLabel.Text;
                }
                else
                {
                    OutPutLabel.Text = OutPutLabel.Text + Convert.ToInt32(flt).ToString();
                }
            }
            if (separate != "")
            {
                if (OutPutLabel.Text.EndsWith(separate) == true)
                {
                    OutPutLabel.Text = OutPutLabel.Text.Substring(0, OutPutLabel.Text.Length - separate.Length);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = true;
                iflt = true;
                floatSegment.Visible = true;
                return;
            }
            else
            {
                checkBox1.Enabled = false;
                iflt = false;
                floatSegment.Visible = false;
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fb == true)
            {
                fb = false;
                return;
            }
            else
            {
                fb = true;
                return;
            }
        }

        private void floatSegment_Click(object sender, EventArgs e)
        {
            if (floatSegment.BackColor == restorecolor)
            {
                flt = true;
                floatSegment.BackColor = activecolor;
                return;
            }
            else
            {
                flt = false;
                floatSegment.BackColor = restorecolor;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(OutPutLabel.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "<none>")
            {
                separate = textBox1.Text;
                if (separate == "~\n") { separate = "\n"; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preactivecolor = activecolor;
            if (LightColor.ShowDialog() == DialogResult.OK)
            {
                activecolor = LightColor.Color;
                if (Segment1.BackColor == preactivecolor) { Segment1.BackColor = activecolor; }
                if (Segment2.BackColor == preactivecolor) { Segment2.BackColor = activecolor; }
                if (Segment3.BackColor == preactivecolor) { Segment3.BackColor = activecolor; }
                if (Segment4.BackColor == preactivecolor) { Segment4.BackColor = activecolor; }
                if (Segment5.BackColor == preactivecolor) { Segment5.BackColor = activecolor; }
                if (Segment6.BackColor == preactivecolor) { Segment6.BackColor = activecolor; }
                if (Segment7.BackColor == preactivecolor) { Segment7.BackColor = activecolor; }
                if (floatSegment.BackColor == preactivecolor) { floatSegment.BackColor = activecolor; }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutPutLabel.Visible = false;
            decodable.Text = "";
            decodable.Visible = true;
            decodable.Select();
        }

        private void decodable_TextChanged(object sender, EventArgs e)
        {

        }

        private void decodable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (separate.Length != 0) { decodable.Text = decodable.Text.Replace(separate, ""); }
                string codestr = decodable.Text.ToString();
                int codetest = Convert.ToInt32(decodable.Text.ToString());
                if (iflt == true)
                {
                    if (fb == true)
                    {
                        flt = Convert.ToBoolean(codetest / 10000000);
                        codestr = codestr.Substring(1, codestr.Length - 1);
                    }
                    if (fb == false)
                    {
                        flt = Convert.ToBoolean(Convert.ToInt32(codestr.Last()));
                        codestr = codestr.Substring(0, codestr.Length - 2);
                    }
                    if (flt == true)
                    {
                        floatSegment.BackColor = activecolor;
                    }
                    else
                    {
                        floatSegment.BackColor = restorecolor;
                    }
                }
                segments[0] = Convert.ToInt32(codestr.ElementAt(0).ToString());
                segments[1] = Convert.ToInt32(codestr.ElementAt(1).ToString());
                segments[2] = Convert.ToInt32(codestr.ElementAt(2).ToString());
                segments[3] = Convert.ToInt32(codestr.ElementAt(3).ToString());
                segments[4] = Convert.ToInt32(codestr.ElementAt(4).ToString());
                segments[5] = Convert.ToInt32(codestr.ElementAt(5).ToString());
                try
                {
                    segments[6] = Convert.ToInt32(codestr.ElementAt(6).ToString());
                }
                catch { }
                if (segments[0] == 1)
                {
                    Segment1.BackColor = activecolor;
                }
                else
                {
                    Segment1.BackColor = restorecolor;
                }


                if (segments[1] == 1)
                {
                    Segment2.BackColor = activecolor;
                }
                else
                {
                    Segment2.BackColor = restorecolor;
                }


                if (segments[2] == 1)
                {
                    Segment3.BackColor = activecolor;
                }
                else
                {
                    Segment3.BackColor = restorecolor;
                }


                if (segments[3] == 1)
                {
                    Segment4.BackColor = activecolor;
                }
                else
                {
                    Segment4.BackColor = restorecolor;
                }


                if (segments[4] == 1)
                {
                    Segment5.BackColor = activecolor;
                }
                else
                {
                    Segment5.BackColor = restorecolor;
                }

                if (segments[5] == 1)
                {
                    Segment6.BackColor = activecolor;
                }
                else
                {
                    Segment6.BackColor = restorecolor;
                }

                if (segments[6] == 1)
                {
                    Segment7.BackColor = activecolor;
                }
                else
                {
                    Segment7.BackColor = restorecolor;
                }
                decodable.Visible = false;
                OutPutLabel.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Segment1.BackgroundImage = Properties.Resources.ink_horizontal1;
                Segment2.BackgroundImage = Properties.Resources.ink_vertical1;
                Segment3.BackgroundImage = Properties.Resources.ink_vertical1;
                Segment4.BackgroundImage = Properties.Resources.ink_horizontal1;
                Segment5.BackgroundImage = Properties.Resources.ink_vertical1;
                Segment6.BackgroundImage = Properties.Resources.ink_vertical1;
                Segment7.BackgroundImage = Properties.Resources.ink_horizontal1;
                floatSegment.BackgroundImage = Properties.Resources.ink_point1;
                label1.BackColor = Color.FromArgb(167, 206, 119);
                restorecolor = Color.FromArgb(147, 186, 99);
                activecolor = Color.Black;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Segment1.BackgroundImage = Properties.Resources.segment_horizontal1;
                Segment2.BackgroundImage = Properties.Resources.segment_vertical1;
                Segment3.BackgroundImage = Properties.Resources.segment_vertical1;
                Segment4.BackgroundImage = Properties.Resources.segment_horizontal1;
                Segment5.BackgroundImage = Properties.Resources.segment_vertical1;
                Segment6.BackgroundImage = Properties.Resources.segment_vertical1;
                Segment7.BackgroundImage = Properties.Resources.segment_horizontal1;
                floatSegment.BackgroundImage = Properties.Resources.segment_point1;
                label1.BackColor = Color.Black;
                restorecolor = Color.DimGray;
                activecolor = Color.Red;
            }
            if (flt == true)
            {
                floatSegment.BackColor = activecolor;
            }
            else if (flt == false)
            {
                floatSegment.BackColor = restorecolor;
            }
            if (segments[0] == 1)
            {
                Segment1.BackColor = activecolor;
            }
            else
            {
                Segment1.BackColor = restorecolor;
            }


            if (segments[1] == 1)
            {
                Segment2.BackColor = activecolor;
            }
            else
            {
                Segment2.BackColor = restorecolor;
            }


            if (segments[2] == 1)
            {
                Segment3.BackColor = activecolor;
            }
            else
            {
                Segment3.BackColor = restorecolor;
            }


            if (segments[3] == 1)
            {
                Segment4.BackColor = activecolor;
            }
            else
            {
                Segment4.BackColor = restorecolor;
            }


            if (segments[4] == 1)
            {
                Segment5.BackColor = activecolor;
            }
            else
            {
                Segment5.BackColor = restorecolor;
            }

            if (segments[5] == 1)
            {
                Segment6.BackColor = activecolor;
            }
            else
            {
                Segment6.BackColor = restorecolor;
            }

            if (segments[6] == 1)
            {
                Segment7.BackColor = activecolor;
            }
            else
            {
                Segment7.BackColor = restorecolor;
            }
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
