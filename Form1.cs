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
            instrukcja.Text = "Kakuro jest to numeryczna krzyżówka. Polega na wpisywaniu cyfr od 1 do 9 tak, aby zsumowały się do liczby wskazanej w pionowym lub poziomym bloku. W jednym bloku nie mogą się powtarzać takie same cyfry. jeśli cyfra jest poprawna to zmieni kolor na zielony.";
            instrukcja.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
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
            p11.Text = "15";
            p11.Font = new System.Drawing.Font("Arial", 6, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p11.Location = new Point(200,60);
            p11.Width = 40;
            p11.Height = 40;

            Label p12 = new Label();
            p12.Text = "20";
            p12.Font = new System.Drawing.Font("Arial", 6, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(60)));
            p12.Location = new Point(240, 60);
            p12.Width = 40;
            p12.Height = 40;

            TextBox p14 = new TextBox();
            p14.Width = 40;
            p14.Height = 40;
            p14.Location = new Point(200,100);

            plansza1.Controls.Add(p11);
            plansza1.Controls.Add(p12);
            plansza1.Controls.Add(p14);
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
