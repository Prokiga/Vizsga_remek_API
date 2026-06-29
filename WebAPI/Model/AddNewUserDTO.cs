using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class AddNewUserDTO
    {
        public string user_name { get; set; }
        [MaxLength(10)]
        public string pass_word { get; set; }
    }
}
