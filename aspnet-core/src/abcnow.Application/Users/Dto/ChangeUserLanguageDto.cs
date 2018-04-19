using System.ComponentModel.DataAnnotations;

namespace abcnow.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}