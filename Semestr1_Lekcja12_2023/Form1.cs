using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr1_Lekcja12_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deklarujemy tablicę string
            string[] tablicaImion = new string[5];

            int index = 0;
            //przekazujemy elementy z listy do tablicy 
            foreach(var item in lista.Items)
            {
                tablicaImion[index] = item.ToString();
                index++;
            }

            //mamy tablicę 5 imion
            // musimy wylosować 1 imię

            //deklarujemy generator liczb
            Random r = new Random();

            // liczba wylosowana musi być w przedziale {0 1 2 3 4}
            int wylosowanaLiczba = r.Next(0,5);

            textBox1.Text = tablicaImion[wylosowanaLiczba];

        }
    }
}
