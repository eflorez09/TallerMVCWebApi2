using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Catalog
{
    public class CatalogContextSeed
    {
        public static async Task SeedAsync(CatalogContext catalogContext)
        {
            if (!catalogContext.Contacts.Any())
            {
                catalogContext.Contacts.AddRange(GetPreconfiguredItems());

                await catalogContext.SaveChangesAsync();
            }
        }
        
        static IEnumerable<Contact> GetPreconfiguredItems()
        {
            return new List<Contact>();
        }
    }
}