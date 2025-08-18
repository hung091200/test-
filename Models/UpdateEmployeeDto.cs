using System.ComponentModel.DataAnnotations;

namespace Nofuture1.Models
{
    public class UpdateEmployeeDto
    {
        [Required]
        [MaxLength(255)]
        public string HoTen { get; set; }

        [Required]
        public int Tuoi { get; set; }

        [Required]
        [MaxLength(20)]
        public string Sdt { get; set; }

        [Required]
        [MaxLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhongBan { get; set; }

        [Required]
        [MaxLength(50)]
        public string ViTri { get; set; }
    }
}
