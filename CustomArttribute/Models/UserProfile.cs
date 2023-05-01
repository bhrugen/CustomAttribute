using CustomArttribute.Utility;
using System.ComponentModel.DataAnnotations;

namespace CustomArttribute.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        [MaxFileResolution(1)]
        [AllowedExtensions(new string[] { ".jpg", ".png" ,".jpeg"})]
        public IFormFile? Image { get; set; }
    }
}
