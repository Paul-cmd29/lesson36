using System.Linq;
using MobileStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MobileStore.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}
