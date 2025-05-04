using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.UI.Models
{
    [Table("Araclar")]
    public class Arac
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Marka { get; set; }

        [MaxLength(30)]
        public string Model { get; set; }

        [Range(1900, 2100)]
        public int Yil { get; set; }

        public int Kilometre { get; set; }

        [MaxLength(20)]
        public string YakitTuru { get; set; }

        [MaxLength(20)]
        public string SanzimanTipi { get; set; }

        [MaxLength(20)]
        public string Renk { get; set; }

        [MaxLength(15)]
        public string Durum { get; set; }

        [MaxLength(15)]
        public string MevcutDurum { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public List<Kiralama> Kiralamalar { get; set; }
        public List<Satis> Satislar { get; set; }

        [NotMapped]
        public bool GeciciSecimDurumu { get; set; }
    }
}
