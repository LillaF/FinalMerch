using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using FinalMerch.Models;

namespace FinalMerch.Models
{
    public class Position
    {

        [Key]
        public int PositionID { get; set; }

        [Required]
        public double XLocation { get; set; }


        public double YLocation { get; set; }

        [Required]
        public int UPC { get; set; }

        public virtual ICollection<Fixture> Fixtures { get; set; }

    }
}
