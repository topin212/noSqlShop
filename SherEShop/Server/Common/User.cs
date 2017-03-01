using System.Collections.Generic;

namespace SherEShop.Server.Common
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
        public int TokenNumber { get; set; }
    }
}