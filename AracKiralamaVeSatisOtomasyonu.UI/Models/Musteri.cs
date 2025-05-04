using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.UI.Models
{
    [Table("Musteriler")]
    public class Musteri
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string AdSoyad { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Adres { get; set; }
        public List<Kiralama> Kiralamalar { get; set; }
        public List<Satis> Satislar { get; set; }
    }
}
