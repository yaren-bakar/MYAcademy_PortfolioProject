using System.ComponentModel.DataAnnotations;

namespace MYAcademy_PortfolioProject.Entities
{
    public class About
    {
        public int AboutID { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı boş bırakılamaz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad Soyad en az 3, en fazla 50 karakter olmalıdır.")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Unvan alanı boş bırakılamaz.")]
        [StringLength(60, ErrorMessage = "Unvan en fazla 60 karakter olabilir.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Konum alanı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Konum en fazla 50 karakter olabilir.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Uzmanlık alanı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Uzmanlık alanı en fazla 50 karakter olabilir.")]
        public string Expert { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "E-posta en fazla 100 karakter olabilir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Açıklama en az 10, en fazla 500 karakter olmalıdır.")]
        public string Description { get; set; }

        public bool OpenToWork { get; set; }
    }
}
