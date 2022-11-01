using System.Linq;
using MobileStore.Models;
using MoblieStore.Models;

namespace MobileStore
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 13",
                        Company = "Apple",
                        Price = 1100
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy S22",
                        Company = "Samsung",
                        Price = 1000
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 950
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
