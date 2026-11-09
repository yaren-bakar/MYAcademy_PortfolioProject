using System.ComponentModel.DataAnnotations;

namespace MYAcademy_PortfolioProject.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }

        [Required(ErrorMessage = "Platform adı boş bırakılamaz.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Platform adı en az 2, en fazla 30 karakter olmalıdır.")]
        public string PlatformName { get; set; }

        [Required(ErrorMessage = "URL adresi boş bırakılamaz.")]
        [Url(ErrorMessage = "Lütfen geçerli bir URL adresi giriniz (örn: https://...).")]
        [StringLength(200, ErrorMessage = "URL en fazla 200 karakter olabilir.")]
        public string Url { get; set; }

        [Required(ErrorMessage = "İkon sınıfı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "İkon sınıfı en fazla 50 karakter olabilir.")]
        public string Icon { get; set; }

        public bool IsActive { get; set; }
    }
}
