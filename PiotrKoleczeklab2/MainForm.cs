using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrKoleczeklab2
{
    public partial class MainForm : Form
    {
        public List<Horse> HorseList { get; set; }

        public MainForm()
        {
            HorseList = new List<Horse>();
            InitializeComponent();
        }

        private void buttonAddHorse_Click(object sender, EventArgs e)
        {
            HorseList.Add(GetHorseData());
            textBoxNumOfObjects.Text = HorseList.Count().ToString();
        }

        private Horse GetHorseData()
        {
            // rezerwacja pamięci dla instancji klasy Horse
            Horse horse = new Horse();
            // nadanie nazwy i numeru atrybutom obiektowi
            horse.Name = textBoxName.Text;
            horse.FavouriteNumber = int.Parse(textBoxNumber.Text);
            // zwrócenie obiektu klasy Horse
            return horse;
        }

        private void buttonDeleteObjects_Click(object sender, EventArgs e)
        {
            HorseList.Clear();
            textBoxNumOfObjects.Text = HorseList.Count().ToString();
        }

        private void buttonAddUnicorn_Click(object sender, EventArgs e)
        {
            Horse horse = GetHorseData();
            Unicorn unicorn = new Unicorn(horse);
            unicorn.UnicornColor = textBoxUnicornColor.Text;
            HorseList.Add(unicorn);
            textBoxNumOfObjects.Text = HorseList.Count().ToString();
        }
    }
}

// konwencja nazewnictwa: ImieNazwiskolabNumer
