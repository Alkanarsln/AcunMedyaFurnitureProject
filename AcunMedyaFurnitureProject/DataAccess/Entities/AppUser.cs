using Microsoft.AspNetCore.Identity;

namespace AcunMedyaFurnitureProject.DataAccess.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string? ImageUrl { get; set; }
    }
}
