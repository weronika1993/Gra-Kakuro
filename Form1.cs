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
            instrukcja.Text = "Kakuro jest to numeryczna krzyżówka. Polega na wpisywaniu cyfr od 1 do 9 tak, aby zsumowały się do liczby wskazanej w pionowym lub poziomym bloku. W jednym bloku nie mogą się powtarzać takie same cyfry. Zabawa podobna jest do popularnej gry sudoku.";
            instrukcja.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(238)));
            instrukcja.Location = new Point(20, 20);
            instrukcja.Width = 300;
            instrukcja.Height = 300;

            //tworzymy nowe okno w którym jest instrukcja gry
            Form okno1 = new Form();
            //wymiary nowego okna
            okno1.Width = 700;
            okno1.Height = 500;
            // napis na nowym oknie
            okno1.Text = "Instrukcja";
            okno1.BackColor = Color.Lavender;
            okno1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            okno1.Controls.Add(instrukcja);
        }

        private void bPlansza1_Click(object sender, EventArgs e)
        {
            Form plansza1 = new Form();
            plansza1.Width = 700;
            plansza1.Height = 700;
        }

        private void bPlansza2_Click(object sender, EventArgs e)
        {

        }

        private void bPlansza3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
