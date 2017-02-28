using System;
using SherEShop.Utilities;

namespace SherEShop.Server.Common.DummyDataProvider
{
    public class DummyGenerator
    {
        public static User CreateDummyUser()
        {
            var rand = new Random().Next(1,999);
            return new User
            {
                Name = "topin" + rand,
                Email = "pigor" + rand + "@gmail.com",
            };
        }

        public static Product CreateDummyProduct()
        {
            var rand = new Random();
            return new Product{name = "npe" + rand.Next() + "c", manufacturer = "Lenivo"};
        }

        public static LiteWrap GenerateDatabase()
        {
            var returnWrap = new LiteWrap();
            returnWrap.AddUser(CreateDummyUser());
            returnWrap.AddProduct(CreateDummyProduct());

            return returnWrap;
        }
    }
}