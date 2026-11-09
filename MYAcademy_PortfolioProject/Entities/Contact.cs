using System.ComponentModel.DataAnnotations;

namespace MYAcademy_PortfolioProject.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz.")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Açıklama en az 10, en fazla 300 karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "E-posta en fazla 100 karakter olabilir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "LinkedIn adresi boş bırakılamaz.")]
        [StringLength(150, ErrorMessage = "LinkedIn adresi en fazla 150 karakter olabilir.")]
        public string Linkedin { get; set; }

        [Required(ErrorMessage = "Konum bilgisi boş bırakılamaz.")]
        [StringLength(60, ErrorMessage = "Konum en fazla 60 karakter olabilir.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "GitHub adresi boş bırakılamaz.")]
        [StringLength(150, ErrorMessage = "GitHub adresi en fazla 150 karakter olabilir.")]
        public string Github { get; set; }

        [Required(ErrorMessage = "Alt bilgi notu boş bırakılamaz.")]
        [StringLength(100, ErrorMessage = "Alt bilgi notu en fazla 100 karakter olabilir.")]
        public string SubDescription { get; set; }
    }
}
