using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[3];
            sayilar[0] = 12;
            sayilar[1] = 5;
            sayilar[2] = 7;
            // sayilar[3] = 3; // Hatalı Atama. Index sayısından fazladır.
            string[] isimler = new string[4];
            isimler[0] = "Negan";
            isimler[1] = "Rick";
            isimler[2] = "Daryl";
            isimler[3] = "Morgan";
            Array.Sort(sayilar);
            Array.Sort(isimler);
            char[] karakterler = new char[4];
            karakterler[0] = 'V';
            karakterler[1] = 'U';
            karakterler[2] = 'A';
            karakterler[3] = 'M';
            Array.Sort(karakterler); // Önce büyükten küçüğe sıralı hale getirir.
            Array.Reverse(karakterler); // Sonra tersine çevirir.
        }

        char[] harfler = new char[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A - Z");
            comboBox1.Items.Add("Z - A");
            Random rastgele = new Random();
            for (int i = 0; i < 10; i++)
            {
                int uretilen_sayi = rastgele.Next(65, 91);
                char uretilen_harf = Convert.ToChar(uretilen_sayi);
                harfler[i] = uretilen_harf;
            }
            foreach (char item in harfler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array.Sort(harfler);
            if (comboBox1.SelectedItem.ToString() == "Z - A")
            {
                Array.Reverse(harfler);
            }
            listBox1.Items.Clear();
            foreach (char karakterler in harfler)
            {
                listBox1.Items.Add(karakterler);
            }
        }
    }
}
// Array'ler (diziler) temel işlemleri hariç algoritma bilgisi gerektiren yapılardır.
// Array sınıf yardımıyla algoritma bilgisi gerekmeden işlemler yapılabilir.
// Array.Sort() => Küçükten büyüğe veya a'dan z'ye sıralama işlemi yapar.
// Array.Reverse() => Diziyi ters çevirme işlemi yapar.