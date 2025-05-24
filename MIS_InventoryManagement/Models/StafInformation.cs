using System.ComponentModel.DataAnnotations;

namespace MIS_InventoryManagement.Models
{
    public class StafInformation
    {
        [Key]
        public int StafId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Dpt { get; set; }

        public string Designation { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public DateTime Date { get; set; }

        // Navigation properties
        public ICollection<PcInformation> PcInformations { get; set; }
        public ICollection<Accessories> Accessories { get; set; }
    }
}
