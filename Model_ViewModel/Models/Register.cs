using Microsoft.AspNetCore.Http;
using Model_ViewModel.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.Models
{
    public class Register
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "تعداد کاراکترهای {0} باید بین 3 و 50 کاراکتر باشد")]
        public string Name { get; set; }


        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "تعداد کاراکترهای {0} باید بین 3 و 50 کاراکتر باشد")]
        public string Family { get; set; }


        [Display(Name = "سن")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [Range(18, 100, ErrorMessage = "{0} کاربر باید بین 18 تا 100 باشد.")]
        public int Age { get; set; }


        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [EmailAddress(ErrorMessage = "{0} شما نامعتبر است.")]
        public string Email { get; set; }


        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string UserName { get; set; }


        [Display(Name = "پسوورد")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "{0} قوی نیست.")]
        public string Password { get; set; }


        [Display(Name = "تایید پسوورد")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [Compare("Password", ErrorMessage = "پسوورد و تایید پسورد باید یکی باشند.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [DataType(DataType.Date, ErrorMessage = "{0} به درستی وارد نشده است.")]
        public DateTime BirthDate { get; set; }


        [Display(Name = "سطح تحصیلات")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public int Degree { get; set; }


        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public int Gender { get; set; }


        [Display(Name = "درباره من")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string Description { get; set; }


        [Display(Name = "با قوانین موافق هستید؟")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "زدن تیک موافقت الزامی است.")]
        public bool IAccept { get; set; }


        [Display(Name = "آدرس وبسایت")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [Url(ErrorMessage = "{0} به درستی وارد نشده است.")]
        public string Website { get; set; }


        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [ImageSizeAttribute(1048576)]
        public IFormFile Image { get; set; }
    }
}
