using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracKiralamaVeSatisOtomasyonu.UI.Models
{
    [Table("Kiralamalar")]
    public class Kiralama
    {
        [Key]
        public int Id { get; set; }

        public int AracId { get; set; }
        public Arac Arac { get; set; }

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal GunlukUcret { get; set; }

        [Column(TypeName = "money")]
        public decimal ToplamTutar { get; set; } // Artık yazılabilir ve veritabanında saklanır
    }
}
