using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;


namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {


        [Required(ErrorMessage="Lütfen Kullanıcı Adınızı Giriniz")]
        public string ?username   { get; set; }

        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
        public string ?password { get; set; }
    }
}
