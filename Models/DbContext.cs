
using System;
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
            Seed();
        }

        private static void Seed()
        {
            var bil1 = new SkapaHyrbilar() { Id = Guid.NewGuid(), Namn = "Bmw", VaxelLadaType = VaxelLadaEnum.Automat, SittPlatserType = SittPlatserEnum.Fem };
            var bil2 = new SkapaHyrbilar() { Id = Guid.NewGuid(), Namn = "Tesla", VaxelLadaType = VaxelLadaEnum.Manuell, SittPlatserType = SittPlatserEnum.Sju };
            var bil3 = new SkapaHyrbilar() { Id = Guid.NewGuid(), Namn = "Ferrari", VaxelLadaType = VaxelLadaEnum.Automat, SittPlatserType = SittPlatserEnum.Två };

            Hyrabilar.Add(bil1);
        }
    }
}
