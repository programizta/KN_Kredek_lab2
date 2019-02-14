using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab2
{
    public class Unicorn : Horse
    {
        /// <summary>
        /// właściwość określająca kolor jednorożca
        /// </summary>
        public string UnicornColor { get; set; }
        public Unicorn()
        {
            // domyślnie nadany kolor
            UnicornColor = "beżowy";
        }
        public Unicorn(Horse horse)
        {
            this.Name = horse.Name;
            this.FavouriteNumber = horse.FavouriteNumber;
        }
        // wpisz "ctor" i dwa razy tab
    }
}
