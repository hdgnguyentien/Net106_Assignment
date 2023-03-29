using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelClient
{
    public class Login : ValidationAttribute
    {
        [Required(ErrorMessage = "Vui lòng không để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng không để trống")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        //[CustomValidation(typeof(LoginRequest), "IsUserExists")]
        public string? MatKhau { get; set; }
    }
}
