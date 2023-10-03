using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_コピペ_
{
    public partial class Form2 : Form
    {
        int buttonKind;
        int buttonNumber;
        public Form2()
        {
            InitializeComponent();
            Load1();
        }
        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title1;
                    textBox2.Text = Properties.Settings.Default.Contents1;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title2;
                    textBox2.Text = Properties.Settings.Default.Contents2;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title3;
                    textBox2.Text = Properties.Settings.Default.Contents3;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title4;
                    textBox2.Text = Properties.Settings.Default.Contents4;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title5;
                    textBox2.Text = Properties.Settings.Default.Contents5;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title6;
                    textBox2.Text = Properties.Settings.Default.Contents6;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title7;
                    textBox2.Text = Properties.Settings.Default.Contents7;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title8;
                    textBox2.Text = Properties.Settings.Default.Contents8;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title9;
                    textBox2.Text = Properties.Settings.Default.Contents9;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title10;
                    textBox2.Text = Properties.Settings.Default.Contents10;
                }
                else if (Properties.Settings.Default.ButtonNumber == 16)
                {
                    textBox1.Text = Properties.Settings.Default.Title31;
                    textBox2.Text = Properties.Settings.Default.Contents31;
                }
                else if (Properties.Settings.Default.ButtonNumber == 17)
                {
                    textBox1.Text = Properties.Settings.Default.Title32;
                    textBox2.Text = Properties.Settings.Default.Contents32;
                }
                else if (Properties.Settings.Default.ButtonNumber == 18)
                {
                    textBox1.Text = Properties.Settings.Default.Title33;
                    textBox2.Text = Properties.Settings.Default.Contents33;
                }
                else if (Properties.Settings.Default.ButtonNumber == 19)
                {
                    textBox1.Text = Properties.Settings.Default.Title34;
                    textBox2.Text = Properties.Settings.Default.Contents34;
                }
                else if (Properties.Settings.Default.ButtonNumber == 20)
                {
                    textBox1.Text = Properties.Settings.Default.Title35;
                    textBox2.Text = Properties.Settings.Default.Contents35;
                }
                else if (Properties.Settings.Default.ButtonNumber == 21)
                {
                    textBox1.Text = Properties.Settings.Default.Title36;
                    textBox2.Text = Properties.Settings.Default.Contents36;
                }
                else if (Properties.Settings.Default.ButtonNumber == 22)
                {
                    textBox1.Text = Properties.Settings.Default.Title37;
                    textBox2.Text = Properties.Settings.Default.Contents37;
                }
                else if (Properties.Settings.Default.ButtonNumber == 23)
                {
                    textBox1.Text = Properties.Settings.Default.Title38;
                    textBox2.Text = Properties.Settings.Default.Contents38;
                }
                else if (Properties.Settings.Default.ButtonNumber == 24)
                {
                    textBox1.Text = Properties.Settings.Default.Title39;
                    textBox2.Text = Properties.Settings.Default.Contents39;
                }
                else if (Properties.Settings.Default.ButtonNumber == 25)
                {
                    textBox1.Text = Properties.Settings.Default.Title40;
                    textBox2.Text = Properties.Settings.Default.Contents40;
                }

            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title11;
                    textBox2.Text = Properties.Settings.Default.Contents11;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title12;
                    textBox2.Text = Properties.Settings.Default.Contents12;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title13;
                    textBox2.Text = Properties.Settings.Default.Contents13;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title14;
                    textBox2.Text = Properties.Settings.Default.Contents14;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title15;
                    textBox2.Text = Properties.Settings.Default.Contents15;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title16;
                    textBox2.Text = Properties.Settings.Default.Contents16;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title17;
                    textBox2.Text = Properties.Settings.Default.Contents17;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title18;
                    textBox2.Text = Properties.Settings.Default.Contents18;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title19;
                    textBox2.Text = Properties.Settings.Default.Contents19;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title20;
                    textBox2.Text = Properties.Settings.Default.Contents20;
                }
                else if (Properties.Settings.Default.ButtonNumber == 16)
                {
                    textBox1.Text = Properties.Settings.Default.Title41;
                    textBox2.Text = Properties.Settings.Default.Contents41;
                }
                else if (Properties.Settings.Default.ButtonNumber == 17)
                {
                    textBox1.Text = Properties.Settings.Default.Title42;
                    textBox2.Text = Properties.Settings.Default.Contents42;
                }
                else if (Properties.Settings.Default.ButtonNumber == 18)
                {
                    textBox1.Text = Properties.Settings.Default.Title43;
                    textBox2.Text = Properties.Settings.Default.Contents43;
                }
                else if (Properties.Settings.Default.ButtonNumber == 19)
                {
                    textBox1.Text = Properties.Settings.Default.Title44;
                    textBox2.Text = Properties.Settings.Default.Contents44;
                }
                else if (Properties.Settings.Default.ButtonNumber == 20)
                {
                    textBox1.Text = Properties.Settings.Default.Title45;
                    textBox2.Text = Properties.Settings.Default.Contents45;
                }
                else if (Properties.Settings.Default.ButtonNumber == 21)
                {
                    textBox1.Text = Properties.Settings.Default.Title46;
                    textBox2.Text = Properties.Settings.Default.Contents46;
                }
                else if (Properties.Settings.Default.ButtonNumber == 22)
                {
                    textBox1.Text = Properties.Settings.Default.Title47;
                    textBox2.Text = Properties.Settings.Default.Contents47;
                }
                else if (Properties.Settings.Default.ButtonNumber == 23)
                {
                    textBox1.Text = Properties.Settings.Default.Title48;
                    textBox2.Text = Properties.Settings.Default.Contents48;
                }
                else if (Properties.Settings.Default.ButtonNumber == 24)
                {
                    textBox1.Text = Properties.Settings.Default.Title49;
                    textBox2.Text = Properties.Settings.Default.Contents49;
                }
                else if (Properties.Settings.Default.ButtonNumber == 25)
                {
                    textBox1.Text = Properties.Settings.Default.Title50;
                    textBox2.Text = Properties.Settings.Default.Contents50;
                }
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title21;
                    textBox2.Text = Properties.Settings.Default.Contents21;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title22;
                    textBox2.Text = Properties.Settings.Default.Contents22;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title23;
                    textBox2.Text = Properties.Settings.Default.Contents23;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title24;
                    textBox2.Text = Properties.Settings.Default.Contents24;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title25;
                    textBox2.Text = Properties.Settings.Default.Contents25;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title26;
                    textBox2.Text = Properties.Settings.Default.Contents26;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title27;
                    textBox2.Text = Properties.Settings.Default.Contents27;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title28;
                    textBox2.Text = Properties.Settings.Default.Contents28;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title29;
                    textBox2.Text = Properties.Settings.Default.Contents29;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title30;
                    textBox2.Text = Properties.Settings.Default.Contents30;
                }
                else if (Properties.Settings.Default.ButtonNumber == 16)
                {
                    textBox1.Text = Properties.Settings.Default.Title51;
                    textBox2.Text = Properties.Settings.Default.Contents51;
                }
                else if (Properties.Settings.Default.ButtonNumber == 17)
                {
                    textBox1.Text = Properties.Settings.Default.Title52;
                    textBox2.Text = Properties.Settings.Default.Contents52;
                }
                else if (Properties.Settings.Default.ButtonNumber == 18)
                {
                    textBox1.Text = Properties.Settings.Default.Title53;
                    textBox2.Text = Properties.Settings.Default.Contents53;
                }
                else if (Properties.Settings.Default.ButtonNumber == 19)
                {
                    textBox1.Text = Properties.Settings.Default.Title54;
                    textBox2.Text = Properties.Settings.Default.Contents54;
                }
                else if (Properties.Settings.Default.ButtonNumber == 20)
                {
                    textBox1.Text = Properties.Settings.Default.Title55;
                    textBox2.Text = Properties.Settings.Default.Contents55;
                }
                else if (Properties.Settings.Default.ButtonNumber == 21)
                {
                    textBox1.Text = Properties.Settings.Default.Title56;
                    textBox2.Text = Properties.Settings.Default.Contents56;
                }
                else if (Properties.Settings.Default.ButtonNumber == 22)
                {
                    textBox1.Text = Properties.Settings.Default.Title57;
                    textBox2.Text = Properties.Settings.Default.Contents57;
                }
                else if (Properties.Settings.Default.ButtonNumber == 23)
                {
                    textBox1.Text = Properties.Settings.Default.Title58;
                    textBox2.Text = Properties.Settings.Default.Contents58;
                }
                else if (Properties.Settings.Default.ButtonNumber == 24)
                {
                    textBox1.Text = Properties.Settings.Default.Title59;
                    textBox2.Text = Properties.Settings.Default.Contents59;
                }
                else if (Properties.Settings.Default.ButtonNumber == 25)
                {
                    textBox1.Text = Properties.Settings.Default.Title60;
                    textBox2.Text = Properties.Settings.Default.Contents60;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonKind = Properties.Settings.Default.ButtonKind;
            buttonNumber = Properties.Settings.Default.ButtonNumber;

            if (buttonKind == 1)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title1 = textBox1.Text;
                    Properties.Settings.Default.Contents1 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title2 = textBox1.Text;
                    Properties.Settings.Default.Contents2 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title3 = textBox1.Text;
                    Properties.Settings.Default.Contents3 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title4 = textBox1.Text;
                    Properties.Settings.Default.Contents4 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title5 = textBox1.Text;
                    Properties.Settings.Default.Contents5 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title6 = textBox1.Text;
                    Properties.Settings.Default.Contents6 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title7 = textBox1.Text;
                    Properties.Settings.Default.Contents7 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title8 = textBox1.Text;
                    Properties.Settings.Default.Contents8 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title9 = textBox1.Text;
                    Properties.Settings.Default.Contents9 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title10 = textBox1.Text;
                    Properties.Settings.Default.Contents10 = textBox2.Text;
                }
                else if (buttonNumber == 16)
                {
                    Properties.Settings.Default.Title31 = textBox1.Text;
                    Properties.Settings.Default.Contents31 = textBox2.Text;
                }
                else if (buttonNumber == 17)
                {
                    Properties.Settings.Default.Title32 = textBox1.Text;
                    Properties.Settings.Default.Contents32 = textBox2.Text;
                }
                else if (buttonNumber == 18)
                {
                    Properties.Settings.Default.Title33 = textBox1.Text;
                    Properties.Settings.Default.Contents33 = textBox2.Text;
                }
                else if (buttonNumber == 19)
                {
                    Properties.Settings.Default.Title34 = textBox1.Text;
                    Properties.Settings.Default.Contents34 = textBox2.Text;
                }
                else if (buttonNumber == 20)
                {
                    Properties.Settings.Default.Title35 = textBox1.Text;
                    Properties.Settings.Default.Contents35 = textBox2.Text;
                }
                else if (buttonNumber == 21)
                {
                    Properties.Settings.Default.Title36 = textBox1.Text;
                    Properties.Settings.Default.Contents36 = textBox2.Text;
                }
                else if (buttonNumber == 22)
                {
                    Properties.Settings.Default.Title37 = textBox1.Text;
                    Properties.Settings.Default.Contents37 = textBox2.Text;
                }
                else if (buttonNumber == 23)
                {
                    Properties.Settings.Default.Title38 = textBox1.Text;
                    Properties.Settings.Default.Contents38 = textBox2.Text;
                }
                else if (buttonNumber == 24)
                {
                    Properties.Settings.Default.Title39 = textBox1.Text;
                    Properties.Settings.Default.Contents39 = textBox2.Text;
                }
                else if (buttonNumber == 25)
                {
                    Properties.Settings.Default.Title40 = textBox1.Text;
                    Properties.Settings.Default.Contents40 = textBox2.Text;
                }
            }
            else if (buttonKind == 2)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title11 = textBox1.Text;
                    Properties.Settings.Default.Contents11 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title12 = textBox1.Text;
                    Properties.Settings.Default.Contents12 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title13 = textBox1.Text;
                    Properties.Settings.Default.Contents13 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title14 = textBox1.Text;
                    Properties.Settings.Default.Contents14 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title15 = textBox1.Text;
                    Properties.Settings.Default.Contents15 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title16 = textBox1.Text;
                    Properties.Settings.Default.Contents16 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title17 = textBox1.Text;
                    Properties.Settings.Default.Contents17 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title18 = textBox1.Text;
                    Properties.Settings.Default.Contents18 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title19 = textBox1.Text;
                    Properties.Settings.Default.Contents19 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title20 = textBox1.Text;
                    Properties.Settings.Default.Contents20 = textBox2.Text;
                }
                else if (buttonNumber == 16)
                {
                    Properties.Settings.Default.Title41 = textBox1.Text;
                    Properties.Settings.Default.Contents41 = textBox2.Text;
                }
                else if (buttonNumber == 17)
                {
                    Properties.Settings.Default.Title42 = textBox1.Text;
                    Properties.Settings.Default.Contents42 = textBox2.Text;
                }
                else if (buttonNumber == 18)
                {
                    Properties.Settings.Default.Title43 = textBox1.Text;
                    Properties.Settings.Default.Contents43 = textBox2.Text;
                }
                else if (buttonNumber == 19)
                {
                    Properties.Settings.Default.Title44 = textBox1.Text;
                    Properties.Settings.Default.Contents44 = textBox2.Text;
                }
                else if (buttonNumber == 20)
                {
                    Properties.Settings.Default.Title45 = textBox1.Text;
                    Properties.Settings.Default.Contents45 = textBox2.Text;
                }
                else if (buttonNumber == 21)
                {
                    Properties.Settings.Default.Title46 = textBox1.Text;
                    Properties.Settings.Default.Contents46 = textBox2.Text;
                }
                else if (buttonNumber == 22)
                {
                    Properties.Settings.Default.Title47 = textBox1.Text;
                    Properties.Settings.Default.Contents47 = textBox2.Text;
                }
                else if (buttonNumber == 23)
                {
                    Properties.Settings.Default.Title48 = textBox1.Text;
                    Properties.Settings.Default.Contents48 = textBox2.Text;
                }
                else if (buttonNumber == 24)
                {
                    Properties.Settings.Default.Title49 = textBox1.Text;
                    Properties.Settings.Default.Contents49 = textBox2.Text;
                }
                else if (buttonNumber == 25)
                {
                    Properties.Settings.Default.Title50 = textBox1.Text;
                    Properties.Settings.Default.Contents50 = textBox2.Text;
                }
            }
            else if (buttonKind == 3)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title21 = textBox1.Text;
                    Properties.Settings.Default.Contents21 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title22 = textBox1.Text;
                    Properties.Settings.Default.Contents22 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title23 = textBox1.Text;
                    Properties.Settings.Default.Contents23 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title24 = textBox1.Text;
                    Properties.Settings.Default.Contents24 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title25 = textBox1.Text;
                    Properties.Settings.Default.Contents25 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title26 = textBox1.Text;
                    Properties.Settings.Default.Contents26 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title27 = textBox1.Text;
                    Properties.Settings.Default.Contents27 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title28 = textBox1.Text;
                    Properties.Settings.Default.Contents28 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title29 = textBox1.Text;
                    Properties.Settings.Default.Contents29 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title30 = textBox1.Text;
                    Properties.Settings.Default.Contents30 = textBox2.Text;
                }
                else if (buttonNumber == 16)
                {
                    Properties.Settings.Default.Title51 = textBox1.Text;
                    Properties.Settings.Default.Contents51 = textBox2.Text;
                }
                else if (buttonNumber == 17)
                {
                    Properties.Settings.Default.Title52 = textBox1.Text;
                    Properties.Settings.Default.Contents52 = textBox2.Text;
                }
                else if (buttonNumber == 18)
                {
                    Properties.Settings.Default.Title53 = textBox1.Text;
                    Properties.Settings.Default.Contents53 = textBox2.Text;
                }
                else if (buttonNumber == 19)
                {
                    Properties.Settings.Default.Title54 = textBox1.Text;
                    Properties.Settings.Default.Contents54 = textBox2.Text;
                }
                else if (buttonNumber == 20)
                {
                    Properties.Settings.Default.Title55 = textBox1.Text;
                    Properties.Settings.Default.Contents55 = textBox2.Text;
                }
                else if (buttonNumber == 21)
                {
                    Properties.Settings.Default.Title56 = textBox1.Text;
                    Properties.Settings.Default.Contents56 = textBox2.Text;
                }
                else if (buttonNumber == 22)
                {
                    Properties.Settings.Default.Title57 = textBox1.Text;
                    Properties.Settings.Default.Contents57 = textBox2.Text;
                }
                else if (buttonNumber == 23)
                {
                    Properties.Settings.Default.Title58 = textBox1.Text;
                    Properties.Settings.Default.Contents58 = textBox2.Text;
                }
                else if (buttonNumber == 24)
                {
                    Properties.Settings.Default.Title59 = textBox1.Text;
                    Properties.Settings.Default.Contents59 = textBox2.Text;
                }
                else if (buttonNumber == 25)
                {
                    Properties.Settings.Default.Title60 = textBox1.Text;
                    Properties.Settings.Default.Contents60 = textBox2.Text;
                }

            }
            Properties.Settings.Default.Save();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    }




       
    
