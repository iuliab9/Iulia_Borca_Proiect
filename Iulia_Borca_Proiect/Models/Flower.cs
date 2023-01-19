using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Iulia_Borca_Proiect.Models
{
    public class Flower
    {
        public int ID { get; set; }
        
        [Display(Name = "Flower Title")]
        public string Type { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price {  get; set; }
        [DataType(DataType.Date)]
        public DateTime BlossomDate { get; set; }


    }
}
