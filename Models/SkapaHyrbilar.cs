using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Hyrabil.Models
{
    public class SkapaHyrbilar
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Namn måste anges")]
        [StringLength(30, ErrorMessage = "Room name cannot be more than 30 characters.")]
        public string Namn { get; set; }

        public VaxelLadaEnum Växellåda { get; set; }

        public SittPlatserEnum Sittplats { get; set; }

        [Required(ErrorMessage = "Size is required.")]
        [Range(3, 8, ErrorMessage = "Floor must be between 0 and 100")]
        public int Sittplatser { get; set; }

        public enum VaxelLadaEnum
        {
            Manuell,
            Automat
        }

        public enum SittPlatserEnum
        {
            Två,
            Fyra,
            Fem,
            Sju
        }
    }
}