using MIS_InventoryManagement.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MIS_InventoryManagement.Models
{
    public class Accessories
    {
        [Key]
        public int AccessoriesID { get; set; }

        public string Device_type { get; set; }

        public string Brand { get; set; }

        public string VandorName { get; set; }

        public string Capasity { get; set; }

        public decimal Price { get; set; }

        public string AddBY { get; set; }

        public DateTime Date { get; set; }

        // Foreign keys
        public int StaffId { get; set; }

        [ForeignKey("StaffId")]
        public StafInformation Staf { get; set; }

        public int PC_SLNO { get; set; }

        [ForeignKey("PC_SLNO")]
        public PcInformation Pc { get; set; }
    }
}



