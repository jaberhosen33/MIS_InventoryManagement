using MIS_InventoryManagement.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MIS_InventoryManagement.Models
{
    public class Accessories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccessoriesID { get; set; }
        [Required]
        public string Device_type { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string VandorName { get; set; }

        public string Capasity { get; set; }

        public decimal Price { get; set; }

        public string AddBY { get; set; }

        public DateTime Date { get; set; }

        // Foreign keys
        public string StaffId { get; set; }

        [ForeignKey("StaffId")]
        public StafInformation Staf { get; set; }

        public string PC_SLNO { get; set; }

        [ForeignKey("PC_SLNO")]
        public PcInformation Pc { get; set; }
    }
}



