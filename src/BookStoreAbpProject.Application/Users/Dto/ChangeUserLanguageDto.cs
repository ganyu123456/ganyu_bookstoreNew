using System.ComponentModel.DataAnnotations;

namespace BookStoreAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}