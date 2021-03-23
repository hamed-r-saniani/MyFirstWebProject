using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.CustomAttributes
{
    public class ImageSizeAttribute : ValidationAttribute
    {
        public int? MaxBytes { get; set; }
        public ImageSizeAttribute(int maxbytes)
        {
            MaxBytes = maxbytes;

            if (MaxBytes.HasValue)
            {
                ErrorMessage = "سایز فایل شما باید کمتر از" + MaxBytes.Value / 1048576 + "مگابایت باشد.";

            }
        }
        public override bool IsValid(object value)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                bool result = true;

                if (MaxBytes.HasValue)
                {
                    result = (file.Length < MaxBytes.Value);
                }
                return result;
            }
            return true;
        }
    }
}
