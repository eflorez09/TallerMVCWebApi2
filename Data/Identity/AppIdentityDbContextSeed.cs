using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Data.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "admin@pica.com", Email = "admin@pica.com" };
            await userManager.CreateAsync(defaultUser, "admin");
        }
    }
}