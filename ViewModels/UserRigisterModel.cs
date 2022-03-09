using System.ComponentModel.DataAnnotations;

namespace chemex.ViewModels
{
    public class UserRigisterModel
    {
        [Required(ErrorMessage = "ПОльзователь должен иметь эмейл")]
        [MaxLength(60)]
        [MinLength(5)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Логин не может быть пуст")]
        [MaxLength(60)]
        [MinLength(5)]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Пароль не может быть пуст")]
        [MaxLength(40)]
        [MinLength(8)]
        public string Password { get; set; }
    }
}