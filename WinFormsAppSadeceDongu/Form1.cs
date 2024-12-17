using System;

namespace WinFormsAppSadeceDongu
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> netflixVeriSeti = new Dictionary<string, List<string>>
{
    { "Diziler", new List<string>
        {
            "Bir Baþkadýr",
            "Kulüp",
            "Atiye",
            "Þahmaran",
            "Aþk 101",
            "Fatma",
            "50m2",
            "Yakamoz S-245"
        }
    },
    { "Filmler", new List<string>
        {
            "Müslüm",
            "Cep Herkülü: Naim Süleymanoðlu",
            "7. Koðuþtaki Mucize",
            "Ayla",
            "Kelebeðin Rüyasý",
            "Dað II",
            "Recep Ývedik 6",
            "Yol Ayrýmý"
        }
    },
    { "Belgeseller", new List<string>
        {
            "Rise of Empires: Ottoman",
            "Ýstanbul'un Fethi",
            "Mehmetçik Kut'ül Amare",
            "Türk Ýþi Dondurma"
        }
    }
};

        public Form1()
        {
            InitializeComponent();

        }



        private void buttonFilmOner_Click_1(object sender, EventArgs e)
        {
            listBoxNetflix.Items.Clear(); // Önce listeyi temizle (isteðe baðlý)

            Random rastgele = new Random();

            foreach (var veriler in netflixVeriSeti)
            {
                string kategori = veriler.Key; // Kategori ismi (örneðin: Diziler, Filmler, Belgeseller)
                List<string> yapimlar = veriler.Value; // Kategorideki yapýmlar listesi

                if (yapimlar.Count > 0) // Liste boþ deðilse
                {
                    int rastgeleIndex = rastgele.Next(0, yapimlar.Count);

                    listBoxNetflix.Items.Add($"{kategori}: {yapimlar[rastgeleIndex]}"); // Her kategoriden ilk elemaný ekle
                }
            }
        }
    }
}
