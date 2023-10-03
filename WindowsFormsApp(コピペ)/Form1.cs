using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_コピペ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Properties.Settings.Default.ButtonKind = 1;
            InitializeComponent();
        }
        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1) {
            button11.BackColor = Color.DeepSkyBlue;
            button12.BackColor = Color.DarkGray;
            button13.BackColor = Color.DarkGray;
            
            button1.Text = Properties.Settings.Default.Title1;
            button2.Text = Properties.Settings.Default.Title2;
            button3.Text = Properties.Settings.Default.Title3;
            button4.Text = Properties.Settings.Default.Title4;
            button5.Text = Properties.Settings.Default.Title5;
            button6.Text = Properties.Settings.Default.Title6;
            button7.Text = Properties.Settings.Default.Title7;
            button8.Text = Properties.Settings.Default.Title8;
            button9.Text = Properties.Settings.Default.Title9;
            button10.Text = Properties.Settings.Default.Title10;
            button16.Text = Properties.Settings.Default.Title31;
            button17.Text = Properties.Settings.Default.Title32;
            button18.Text = Properties.Settings.Default.Title33;
            button19.Text = Properties.Settings.Default.Title34;
            button20.Text = Properties.Settings.Default.Title35;
            button21.Text = Properties.Settings.Default.Title36;
            button22.Text = Properties.Settings.Default.Title37;
            button23.Text = Properties.Settings.Default.Title38;
            button24.Text = Properties.Settings.Default.Title39;
            button25.Text = Properties.Settings.Default.Title40;
            }
            else if(Properties.Settings.Default.ButtonKind == 2) 
            {

                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DeepSkyBlue;
                button13.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title11;
                button2.Text = Properties.Settings.Default.Title12;
                button3.Text = Properties.Settings.Default.Title13;
                button4.Text = Properties.Settings.Default.Title14;
                button5.Text = Properties.Settings.Default.Title15;
                button6.Text = Properties.Settings.Default.Title16;
                button7.Text = Properties.Settings.Default.Title17;
                button8.Text = Properties.Settings.Default.Title18;
                button9.Text = Properties.Settings.Default.Title19;
                button10.Text = Properties.Settings.Default.Title20;
                button16.Text = Properties.Settings.Default.Title41;
                button17.Text = Properties.Settings.Default.Title42;
                button18.Text = Properties.Settings.Default.Title43;
                button19.Text = Properties.Settings.Default.Title44;
                button20.Text = Properties.Settings.Default.Title45;
                button21.Text = Properties.Settings.Default.Title46;
                button22.Text = Properties.Settings.Default.Title47;
                button23.Text = Properties.Settings.Default.Title48;
                button24.Text = Properties.Settings.Default.Title49;
                button25.Text = Properties.Settings.Default.Title50;

            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {

                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DarkGray;
                button13.BackColor = Color.DeepSkyBlue;

                button1.Text = Properties.Settings.Default.Title21;
                button2.Text = Properties.Settings.Default.Title22;
                button3.Text = Properties.Settings.Default.Title23;
                button4.Text = Properties.Settings.Default.Title24;
                button5.Text = Properties.Settings.Default.Title25;
                button6.Text = Properties.Settings.Default.Title26;
                button7.Text = Properties.Settings.Default.Title27;
                button8.Text = Properties.Settings.Default.Title28;
                button9.Text = Properties.Settings.Default.Title29;
                button10.Text = Properties.Settings.Default.Title30;
                button16.Text = Properties.Settings.Default.Title51;
                button17.Text = Properties.Settings.Default.Title52;
                button18.Text = Properties.Settings.Default.Title53;
                button19.Text = Properties.Settings.Default.Title54;
                button20.Text = Properties.Settings.Default.Title55;
                button21.Text = Properties.Settings.Default.Title56;
                button22.Text = Properties.Settings.Default.Title57;
                button23.Text = Properties.Settings.Default.Title58;
                button24.Text = Properties.Settings.Default.Title59;
                button25.Text = Properties.Settings.Default.Title60;
            }
            button11.Text = Properties.Settings.Default.TabName1;
            button12.Text = Properties.Settings.Default.TabName2;
            button13.Text = Properties.Settings.Default.TabName3;
        }
        

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if(Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents1);
                }
                else if(Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents11);
                }
                else if(Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents21);
                }
            }
            else if(e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 2;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents2);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents12);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents22);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 3;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents3);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents13);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents23);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 4;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents4);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents14);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents24);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 5;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents5);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents15);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents25);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 6;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents6);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents16);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents26);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 7;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents7);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents17);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents27);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 8;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents8);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents18);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents28);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 9;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents9);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents19);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents29);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }
        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 10;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents10);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents20);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents30);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 16;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents31);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents41);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents51);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 17;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents32);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents42);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents52);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 18;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents33);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents43);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents53);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 19;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents34);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents44);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents54);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button20_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 20;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents35);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents45);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents55);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button21_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 21;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents36);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents46);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents56);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button22_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 22;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents37);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents47);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents57);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button23_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 23;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents38);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents48);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents58);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button24_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 24;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents39);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents49);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents59);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button25_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 25;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents40);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents50);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents60);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Load1();
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 1;
                Load1();
            }
            else if(e.Button.ToString() =="Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 2;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 3;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }


        
    }
    
}
