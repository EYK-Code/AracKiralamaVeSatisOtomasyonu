using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.UI.Models
{
    [Table("Satislar")]
    public class Satis
    {
        [Key]
        public int Id { get; set; }
        public int AracId { get; set; }
        public Arac Arac { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        [Column(TypeName = "date")]
        public DateTime SatisTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal SatisFiyati { get; set; }

        [Required]
        [MaxLength(20)]
        public string OdemeTipi { get; set; }
    }
}
