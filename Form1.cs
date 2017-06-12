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
                "lub poziomym bloku. W jednym bloku nie mogą się powtarzać takie same cyfry. Jeśli cyfra jest poprawna to zmieni kolor na zielony." +
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
            plansza1.Width = 600;
            plansza1.Height = 600;
            plansza1.Text = "Prosta plansza";
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

            TextBox p15 = new TextBox();
            p15.Width = 40;
            p15.Height = 40;
            p15.Location = new Point(240, 100);

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

            TextBox p19 = new TextBox();
            p19.Width = 40;
            p19.Height = 40;
            p19.Location = new Point(200, 140);

            TextBox p110 = new TextBox();
            p110.Width = 40;
            p110.Height = 40;
            p110.Location = new Point(240, 140);

            TextBox p111 = new TextBox();
            p111.Width = 40;
            p111.Height = 40;
            p111.Location = new Point(280, 140);

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

            TextBox p114 = new TextBox();
            p114.Width = 40;
            p114.Height = 40;
            p114.Location = new Point(200, 180);

            TextBox p115 = new TextBox();
            p115.Width = 40;
            p115.Height = 40;
            p115.Location = new Point(240, 180);

            TextBox p116 = new TextBox();
            p116.Width = 40;
            p116.Height = 40;
            p116.Location = new Point(280, 180);

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

            TextBox p119 = new TextBox();
            p119.Width = 40;
            p119.Height = 40;
            p119.Location = new Point(240,220);

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

        }

        private void bPlansza3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
