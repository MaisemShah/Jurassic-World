using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jurasssic_World.Data
{
    public class Dinosaurs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DID { get; set; }
        [Display(Name = "Dinosaur Name")]
        public string DN { get; set; }
        [Display(Name = "Dinosaur Size")]

        public string DS { get; set; }

        public int EID { get; set; }
        [ForeignKey("EID")]
        public Exhibits ExID { get; set; }

    }
}
