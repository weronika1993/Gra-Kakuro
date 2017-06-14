using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kakuro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bInstrukcja_Click(object sender, EventArgs e)
        {
            Label instrukcja = new Label();
            instrukcja.Text = "Kakuro jest to numeryczna krzyżówka. Polega na wpisywaniu cyfr od 1 do 9 tak, aby zsumowały się do liczby wskazanej w pionowym" +
                "lub poziomym bloku. W jednym bloku nie mogą się powtarzać takie same cyfry. Jeśli cyfra jest poprawna to tło zmieni kolor na zielony." +
                "Cyfra przy której stoi strzałka oznacza sumę w rzędzie poziomym, zaś cyfra przed znaczkiem '|' oznacza sumę w rzędzie pionowym.";
            instrukcja.Font = new System.Drawing.Font("Arial", 5, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            instrukcja.Location = new Point(20, 20);
            instrukcja.Width = 500;
            instrukcja.Height = 500;

            //tworzymy nowe okno w którym jest instrukcja gry
            Form okno1 = new Form();
            //wymiary nowego okna
            okno1.Width = 700;
            okno1.Height = 500;
            // napis na nowym oknie
            okno1.Text = "Instrukcja";
            okno1.BackColor = Color.Honeydew;
            okno1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            okno1.Controls.Add(instrukcja);
            okno1.ShowDialog();
        }
     
        private void bPlansza1_Click(object sender, EventArgs e)
        {
            Form plansza1 = new Form();
            plansza1.Width = 500;
            plansza1.Height = 500;
            plansza1.Text = "Plansza na rozgrzewkę :)";
            plansza1.BackColor = Color.AntiqueWhite;
            plansza1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            //pierwsze pole
            Label p11 = new Label();
            p11.Text = "15|";
            p11.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p11.Location = new Point(200,60);
            p11.Width = 40;
            p11.Height = 40;

            Label p12 = new Label();
            p12.Text = "20|";
            p12.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p12.Location = new Point(240, 60);
            p12.Width = 40;
            p12.Height = 40;


            Label p13 = new Label();
            p13.Text = "9|5>";
            p13.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p13.Location = new Point(160, 100);
            p13.Width = 40;
            p13.Height = 40;

            TextBox p14 = new TextBox();
            p14.Width = 40;
            p14.Height = 40;
            p14.Location = new Point(200,100);
            if(p14.Text == "2")
            {
                p14.BackColor = Color.Green;
            }
            else
            {
                p14.BackColor = Color.FloralWhite;
            }
            

            TextBox p15 = new TextBox();
            p15.Width = 40;
            p15.Height = 40;
            p15.Location = new Point(240, 100);
            if (p15.Text == "3")
            {
                p15.BackColor = Color.Green;
            }
            else
            {
                p15.BackColor = Color.FloralWhite;
            }

            Label p16 = new Label();
            p16.Text = "9|";
            p16.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p16.Location = new Point(280, 100);
            p16.Width = 40;
            p16.Height = 40;

            Label p17 = new Label();
            p17.Text = "28>";
            p17.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p17.Location = new Point(120, 140);
            p17.Width = 40;
            p17.Height = 40;

            TextBox p18 = new TextBox();
            p18.Width = 40;
            p18.Height = 40;
            p18.Location = new Point(160, 140);
            if (p18.Text == "4")
            {
                p18.BackColor = Color.Green;
            }
            else
            {
                p18.BackColor = Color.FloralWhite;
            }


            TextBox p19 = new TextBox();
            p19.Width = 40;
            p19.Height = 40;
            p19.Location = new Point(200, 140);
            if (p19.Text == "8")
            {
                p19.BackColor = Color.Green;
            }
            else
            {
                p19.BackColor = Color.FloralWhite;
            }

            TextBox p110 = new TextBox();
            p110.Width = 40;
            p110.Height = 40;
            p110.Location = new Point(240, 140);
            if (p110.Text == "9")
            {
                p110.BackColor = Color.Green;
            }
            else
            {
                p110.BackColor = Color.FloralWhite;
            }

            TextBox p111 = new TextBox();
            p111.Width = 40;
            p111.Height = 40;
            p111.Location = new Point(280, 140);
            if (p111.Text == "7")
            {
                p111.BackColor = Color.Green;
            }
            else
            {
                p111.BackColor = Color.FloralWhite;
            }


            Label p112 = new Label();
            p112.Text = "12>";
            p112.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p112.Location = new Point(120, 180);
            p112.Width = 40;
            p112.Height = 40;

            TextBox p113 = new TextBox();
            p113.Width = 40;
            p113.Height = 40;
            p113.Location = new Point(160, 180);
            if (p113.Text == "5")
            {
                p113.BackColor = Color.Green;
            }
            else
            {
                p113.BackColor = Color.FloralWhite;
            }

            TextBox p114 = new TextBox();
            p114.Width = 40;
            p114.Height = 40;
            p114.Location = new Point(200, 180);
            if (p114.Text == "4")
            {
                p114.BackColor = Color.Green;
            }
            else
            {
                p114.BackColor = Color.FloralWhite;
            }

            TextBox p115 = new TextBox();
            p115.Width = 40;
            p115.Height = 40;
            p115.Location = new Point(240, 180);
            if (p115.Text == "1")
            {
                p115.BackColor = Color.Green;
            }
            else
            {
                p115.BackColor = Color.FloralWhite;
            }

            TextBox p116 = new TextBox();
            p116.Width = 40;
            p116.Height = 40;
            p116.Location = new Point(280, 180);
            if (p116.Text == "2")
            {
                p116.BackColor = Color.Green;
            }
            else
            {
                p116.BackColor = Color.FloralWhite;
            }

            Label p117 = new Label();
            p117.Text = "8>";
            p117.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p117.Location = new Point(160, 220);
            p117.Width = 40;
            p117.Height = 40;

            TextBox p118 = new TextBox();
            p118.Width = 40;
            p118.Height = 40;
            p118.Location = new Point(200, 220);
            if (p118.Text == "1")
            {
                p118.BackColor = Color.Green;
            }
            else
            {
                p118.BackColor = Color.FloralWhite;
            }

            TextBox p119 = new TextBox();
            p119.Width = 40;
            p119.Height = 40;
            p119.Location = new Point(240,220);
            if (p119.Text == "7")
            {
                p119.BackColor = Color.Green;
            }
            else
            {
                p119.BackColor = Color.FloralWhite;
            }

            plansza1.Controls.Add(p11);
            plansza1.Controls.Add(p12);
            plansza1.Controls.Add(p13);
            plansza1.Controls.Add(p14);
            plansza1.Controls.Add(p15);
            plansza1.Controls.Add(p16);
            plansza1.Controls.Add(p17);
            plansza1.Controls.Add(p18);
            plansza1.Controls.Add(p19);
            plansza1.Controls.Add(p110);
            plansza1.Controls.Add(p111);
            plansza1.Controls.Add(p112);
            plansza1.Controls.Add(p113);
            plansza1.Controls.Add(p114);
            plansza1.Controls.Add(p115);
            plansza1.Controls.Add(p116);
            plansza1.Controls.Add(p117);
            plansza1.Controls.Add(p118);
            plansza1.Controls.Add(p119);
            plansza1.ShowDialog();
        }

        private void bPlansza2_Click(object sender, EventArgs e)
        {
            Form plansza2 = new Form();
            plansza2.Width = 600;
            plansza2.Height = 600;
            plansza2.Text = "Plansza Trudna";
            plansza2.BackColor = Color.AntiqueWhite;
            plansza2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            #region instrukcja
            Label p21 = new Label();
            p21.Text = "4|";
            p21.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p21.Location = new Point(160, 60);
            p21.Width = 50;
            p21.Height = 40;

            Label p22 = new Label();
            p22.Text = "10|";
            p22.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p22.Location = new Point(210, 60);
            p22.Width = 50;
            p22.Height = 40;

            Label p23 = new Label();
            p23.Text = "4>";
            p23.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p23.Location = new Point(110, 100);
            p23.Width = 50;
            p23.Height = 40;

            Label p26 = new Label();
            p26.Text = "3|";
            p26.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p26.Location = new Point(310, 100);
            p26.Width = 50;
            p26.Height = 40;

            Label p27 = new Label();
            p27.Text = "3|";
            p27.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p27.Location = new Point(360, 100);
            p27.Width = 50;
            p27.Height = 40;

            Label p28 = new Label();
            p28.Text = "3>";
            p28.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p28.Location = new Point(110, 140);
            p28.Width = 50;
            p28.Height = 40;

            Label p211 = new Label();
            p211.Text = "11|4>";
            p211.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p211.Location = new Point(260, 140);
            p211.Width = 50;
            p211.Height = 40;

            Label p214 = new Label();
            p214.Text = "3|";
            p214.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p214.Location = new Point(110, 180);
            p214.Width = 50;
            p214.Height = 40;


            Label p215 = new Label();
            p215.Text = "4|10>";
            p215.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p215.Location = new Point(160, 180);
            p215.Width = 50;
            p215.Height = 40;


            Label p220 = new Label();
            p220.Text = "11|";
            p220.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p220.Location = new Point(60, 220);
            p220.Width = 50;
            p220.Height = 40;

            Label p225 = new Label();
            p225.Text = "4|";
            p225.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p225.Location = new Point(310, 220);
            p225.Width = 50;
            p225.Height = 40;

            Label p226 = new Label();
            p226.Text = "4>";
            p226.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p226.Location = new Point(60, 260);
            p226.Width = 50;
            p226.Height = 40;

            Label p229 = new Label();
            p229.Text = "4>";
            p229.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p229.Location = new Point(210, 260);
            p229.Width = 50;
            p229.Height = 40;

            Label p232 = new Label();
            p232.Text = "3>";
            p232.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p232.Location = new Point(210, 300);
            p232.Width = 50;
            p232.Height = 40;
            #endregion instrukcja
            #region pola
            TextBox p24 = new TextBox();
            p24.Width = 50;
            p24.Height = 40;
            p24.Location = new Point(160, 100);
            if (p24.Text == "3")
            {
                p24.BackColor = Color.Green;
            }
            else
            {
                p24.BackColor = Color.FloralWhite;
            }

            TextBox p25 = new TextBox();
            p25.Width = 50;
            p25.Height = 40;
            p25.Location = new Point(210, 100);
            if (p25.Text == "1")
            {
                p25.BackColor = Color.Green;
            }
            else
            {
                p25.BackColor = Color.FloralWhite;
            }

            TextBox p29 = new TextBox();
            p29.Width = 50;
            p29.Height = 40;
            p29.Location = new Point(160, 140);
            if (p29.Text == "1")
            {
                p29.BackColor = Color.Green;
            }
            else
            {
                p29.BackColor = Color.FloralWhite;
            }

            TextBox p210 = new TextBox();
            p210.Width = 50;
            p210.Height = 40;
            p210.Location = new Point(210, 140);
            if (p210.Text == "2")
            {
                p210.BackColor = Color.Green;
            }
            else
            {
                p210.BackColor = Color.FloralWhite;
            }

            TextBox p212 = new TextBox();
            p212.Width = 50;
            p212.Height = 40;
            p212.Location = new Point(310, 140);
            if (p212.Text == "1")
            {
                p212.BackColor = Color.Green;
            }
            else
            {
                p212.BackColor = Color.FloralWhite;
            }

            TextBox p213 = new TextBox();
            p213.Width = 50;
            p213.Height = 40;
            p213.Location = new Point(360, 140);
            if (p213.Text == "3")
            {
                p213.BackColor = Color.Green;
            }
            else
            {
                p213.BackColor = Color.FloralWhite;
            }

            TextBox p216 = new TextBox();
            p216.Width = 50;
            p216.Height = 40;
            p216.Location = new Point(210, 180);
            if (p216.Text == "4")
            {
                p216.BackColor = Color.Green;
            }
            else
            {
                p216.BackColor = Color.FloralWhite;
            }

            TextBox p217 = new TextBox();
            p217.Width = 50;
            p217.Height = 40;
            p217.Location = new Point(260, 180);
            if (p217.Text == "3")
            {
                p217.BackColor = Color.Green;
            }
            else
            {
                p217.BackColor = Color.FloralWhite;
            }

            TextBox p218 = new TextBox();
            p218.Width = 50;
            p218.Height = 40;
            p218.Location = new Point(310, 180);
            if (p218.Text == "2")
            {
                p218.BackColor = Color.Green;
            }
            else
            {
                p218.BackColor = Color.FloralWhite;
            }

            TextBox p219 = new TextBox();
            p219.Width = 50;
            p219.Height = 40;
            p219.Location = new Point(360, 180);
            if (p219.Text == "1")
            {
                p219.BackColor = Color.Green;
            }
            else
            {
                p219.BackColor = Color.FloralWhite;
            }

            TextBox p221 = new TextBox();
            p221.Width = 50;
            p221.Height = 40;
            p221.Location = new Point(110, 220);
            if (p221.Text == "2")
            {
                p221.BackColor = Color.Green;
            }
            else
            {
                p221.BackColor = Color.FloralWhite;
            }


            TextBox p222 = new TextBox();
            p222.Width = 50;
            p222.Height = 40;
            p222.Location = new Point(160, 220);
            if (p221.Text == "1")
            {
                p222.BackColor = Color.Green;
            }
            else
            {
                p222.BackColor = Color.FloralWhite;
            }


            TextBox p223 = new TextBox();
            p223.Width = 50;
            p223.Height = 40;
            p223.Location = new Point(210, 220);
            if (p223.Text == "3")
            {
                p223.BackColor = Color.Green;
            }
            else
            {
                p223.BackColor = Color.FloralWhite;
            }


            TextBox p224 = new TextBox();
            p224.Width = 50;
            p224.Height = 40;
            p224.Location = new Point(260, 220);
            if (p224.Text == "5")
            {
                p224.BackColor = Color.Green;
            }
            else
            {
                p224.BackColor = Color.FloralWhite;
            }

            TextBox p227 = new TextBox();
            p227.Width = 50;
            p227.Height = 40;
            p227.Location = new Point(110, 260);
            if (p227.Text == "1")
            {
                p227.BackColor = Color.Green;
            }
            else
            {
                p227.BackColor = Color.FloralWhite;
            }

            TextBox p228 = new TextBox();
            p228.Width = 50;
            p228.Height = 40;
            p228.Location = new Point(160, 220);
            if (p228.Text == "3")
            {
                p228.BackColor = Color.Green;
            }
            else
            {
                p228.BackColor = Color.FloralWhite;
            }

            TextBox p230 = new TextBox();
            p230.Width = 50;
            p230.Height = 40;
            p230.Location = new Point(260, 260);
            if (p230.Text == "1")
            {
                p230.BackColor = Color.Green;
            }
            else
            {
                p230.BackColor = Color.FloralWhite;
            }

            TextBox p231 = new TextBox();
            p231.Width = 50;
            p231.Height = 40;
            p231.Location = new Point(310, 260);
            if (p231.Text == "3")
            {
                p231.BackColor = Color.Green;
            }
            else
            {
                p231.BackColor = Color.FloralWhite;
            }

            TextBox p233 = new TextBox();
            p233.Width = 50;
            p233.Height = 40;
            p233.Location = new Point(260, 300);
            if (p233.Text == "2")
            {
                p233.BackColor = Color.Green;
            }
            else
            {
                p233.BackColor = Color.FloralWhite;
            }

            TextBox p234 = new TextBox();
            p234.Width = 50;
            p234.Height = 40;
            p234.Location = new Point(310, 300);
            if (p234.Text == "1")
            {
                p234.BackColor = Color.Green;
            }
            else
            {
                p234.BackColor = Color.FloralWhite;
            }

            #endregion pola
            plansza2.Controls.Add(p21);
            plansza2.Controls.Add(p22);
            plansza2.Controls.Add(p23);
            plansza2.Controls.Add(p26);
            plansza2.Controls.Add(p27);
            plansza2.Controls.Add(p28);
            plansza2.Controls.Add(p211);
            plansza2.Controls.Add(p214);
            plansza2.Controls.Add(p215);
            plansza2.Controls.Add(p220);
            plansza2.Controls.Add(p225);
            plansza2.Controls.Add(p226);
            plansza2.Controls.Add(p229);
            plansza2.Controls.Add(p232);
            plansza2.Controls.Add(p24);
            plansza2.Controls.Add(p25);
            plansza2.Controls.Add(p29);
            plansza2.Controls.Add(p210);
            plansza2.Controls.Add(p212);
            plansza2.Controls.Add(p213);
            plansza2.Controls.Add(p216);
            plansza2.Controls.Add(p217);
            plansza2.Controls.Add(p218);
            plansza2.Controls.Add(p219);
            plansza2.Controls.Add(p221);
            plansza2.Controls.Add(p222);
            plansza2.Controls.Add(p223);
            plansza2.Controls.Add(p224);
            plansza2.Controls.Add(p227);
            plansza2.Controls.Add(p228);
            plansza2.Controls.Add(p230);
            plansza2.Controls.Add(p231);
            plansza2.Controls.Add(p233);
            plansza2.Controls.Add(p234);
            plansza2.ShowDialog();
        }

       
    }
}
