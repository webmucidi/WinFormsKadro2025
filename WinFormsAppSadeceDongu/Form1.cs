using System;

namespace WinFormsAppSadeceDongu
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> netflixVeriSeti = new Dictionary<string, List<string>>
{
    { "Diziler", new List<string>
        {
            "Bir Ba�kad�r",
            "Kul�p",
            "Atiye",
            "�ahmaran",
            "A�k 101",
            "Fatma",
            "50m2",
            "Yakamoz S-245"
        }
    },
    { "Filmler", new List<string>
        {
            "M�sl�m",
            "Cep Herk�l�: Naim S�leymano�lu",
            "7. Ko�u�taki Mucize",
            "Ayla",
            "Kelebe�in R�yas�",
            "Da� II",
            "Recep �vedik 6",
            "Yol Ayr�m�"
        }
    },
    { "Belgeseller", new List<string>
        {
            "Rise of Empires: Ottoman",
            "�stanbul'un Fethi",
            "Mehmet�ik Kut'�l Amare",
            "T�rk ��i Dondurma"
        }
    }
};

        public Form1()
        {
            InitializeComponent();

        }



        private void buttonFilmOner_Click_1(object sender, EventArgs e)
        {
            listBoxNetflix.Items.Clear(); // �nce listeyi temizle (iste�e ba�l�)

            Random rastgele = new Random();

            foreach (var veriler in netflixVeriSeti)
            {
                string kategori = veriler.Key; // Kategori ismi (�rne�in: Diziler, Filmler, Belgeseller)
                List<string> yapimlar = veriler.Value; // Kategorideki yap�mlar listesi

                if (yapimlar.Count > 0) // Liste bo� de�ilse
                {
                    int rastgeleIndex = rastgele.Next(0, yapimlar.Count);

                    listBoxNetflix.Items.Add($"{kategori}: {yapimlar[rastgeleIndex]}"); // Her kategoriden ilk eleman� ekle
                }
            }
        }
    }
}
