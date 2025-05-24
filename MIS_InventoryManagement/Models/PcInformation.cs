using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MIS_InventoryManagement.Models
{

    public class PcInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int SlNo { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }

        [StringLength(50)]
        public string ModelNo { get; set; }

        [StringLength(20)]
        public string Ram { get; set; }

        [StringLength(20)]
        public string Ssd { get; set; }

        [StringLength(20)]
        public string Hhd { get; set; }

        [StringLength(50)]
        public string Processor { get; set; }

        [StringLength(20)]
        public string Generation { get; set; }

        [StringLength(100)]
        public string VandorName { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        // Foreign key
        public int StafId { get; set; }

        [ForeignKey("StafId")]
        public StafInformation Staf { get; set; }

        public ICollection<Accessories> Accessories { get; set; }
    }

}

