using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasitVeriTabanıBağlantısı.DataModel
{
    public class Auth
    {

        [Key]
        public int Id { get; set; }



        [DisplayName("Emailinizi giriniz")]
        public string Email { get; set; }


        [DisplayName("Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
