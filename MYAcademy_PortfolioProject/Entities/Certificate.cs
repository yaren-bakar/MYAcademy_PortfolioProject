using System.ComponentModel.DataAnnotations;

namespace MYAcademy_PortfolioProject.Entities
{
    public class Certificate
    {
        public int CertificateID { get; set; }

        [Required(ErrorMessage = "Sertifika adı boş bırakılamaz.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Sertifika adı en az 3, en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Kurum adı boş bırakılamaz.")]
        [StringLength(100, ErrorMessage = "Kurum adı en fazla 100 karakter olabilir.")]
        public string Institution { get; set; }

        [Required(ErrorMessage = "Sertifika tarihi boş bırakılamaz.")]
        [StringLength(20, ErrorMessage = "Tarih bilgisi en fazla 20 karakter olabilir.")]
        public string CertificateDate { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz.")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Açıklama en az 5, en fazla 150 karakter olmalıdır.")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
