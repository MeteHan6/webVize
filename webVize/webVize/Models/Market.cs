using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webVize.Models
{
    public class Market
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Fiyat { get; set; }


        public static List<Market> MarketListesi = new List<Market>
        {
                 new Market
             {
                 Id=1,
                 Ad="Bisküvi",
                 Fiyat="2TL",
             },
                  new Market
             {
                 Id=2,
                 Ad="Gofret",
                 Fiyat="1TL",
             },
                   new Market
             {
                 Id=3,
                 Ad="Kek",
                 Fiyat="1TL",
             }
        };
    }
}