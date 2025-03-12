using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int liczba_pierwsza;
        private int liczba_druga;
        private int suma;
        private int roznica;
        private int iloczyn;
        private int iloraz;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private int liczba_pierwsza;
        //private int liczba_druga;
        private void spr_dane()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // tutaj uzytkownik wpisuje zmienną i to jest zmienna o nazwie Liczba1 !!!
            //int liczba_pierwsza;

            liczba_pierwsza = 0;
            if (int.TryParse(Liczba1.Text, out int liczba))
            {
                liczba_pierwsza = liczba;
            } 
            else
            {
                MessageBox.Show("Prosze wpisywac tylko liczby!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Liczba1.Clear();
            }
            //e
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            suma = liczba_pierwsza + liczba_druga;
            label1.Text = suma.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Liczba2_TextChanged(object sender, EventArgs e)
        {
            // tutaj: Liczba2 !!!
            //int liczba_druga;
            liczba_druga = 0;

            //string liczbaTekst = Liczba2.Text.Replace(" ", "");

            if (int.TryParse(Liczba2.Text, out int liczb))
            {
                liczba_druga = liczb;
            }
            else
            {
                MessageBox.Show("Prosze wpisywac tylko liczby!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Liczba2.Clear();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            iloraz = liczba_pierwsza / liczba_druga;
            label1.Text = iloraz.ToString();
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            roznica = liczba_pierwsza - liczba_druga;
            label1.Text = roznica.ToString();
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            iloczyn = liczba_pierwsza * liczba_druga;
            label1.Text = iloczyn.ToString();
        }
    }
}
