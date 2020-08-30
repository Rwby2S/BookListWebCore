using System.ComponentModel.DataAnnotations;

namespace BookListWebCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}