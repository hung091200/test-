
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nofuture1.Models.Entities;

[Table("NhanVien")]
public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

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
