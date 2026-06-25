using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class users
    {
        [Key]
        public int user_id { get; set; }
        [MaxLength(50)]
        public string user_name { get; set; }
        [MaxLength(10)]
        public string pass_word { get; set; }
    }
}
