using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Вкажiть ваше iм'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставте першу адресу доставки")]
        [Display(Name = "Перша адреса")]
        public string Line1 { get; set; }

        [Display(Name = "Друга адреса")]
        public string Line2 { get; set; }

        [Display(Name = "Третя адреса")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Вкажiть мiсто")]
        [Display(Name = "Мiсто")]
        public string City { get; set; }

        [Required(ErrorMessage = "Вкажiть країну")]
        [Display(Name = "Країна")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

    }
}
