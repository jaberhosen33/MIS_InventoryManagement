using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIS_InventoryManagement.Models
{
    public class StafInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StafId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Dpt { get; set; }

        public string Designation { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Mail { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Navigation properties
        public ICollection<PcInformation> PcInformations { get; set; }
        public ICollection<Accessories> Accessories { get; set; }
    }
}
