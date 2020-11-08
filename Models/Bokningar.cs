using System;

namespace HyraBilar.Models
{
    public class Bokningar
    {
        public Guid Id { get; set; }
        public Guid SkapaHyrbilarId { get; set; }
        public string SkapaHyrbilarNamn { get; set; }
        public string Bokare { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
    }
}