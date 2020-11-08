
using System.Collections.Generic;
using Hyrabil.Models;

namespace HyraBilar.Models
{
    public static class DbContext
    {
        public static List<SkapaHyrbilar> Hyrabilar { get; set; }
        public static List<Bokningar> Minabokningar { get; set; }

        static DbContext()
        {
            Hyrabilar = new List<SkapaHyrbilar>();

            Minabokningar = new List<Bokningar>();

        }
    }
}