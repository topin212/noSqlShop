using System;
using System.Collections;
using System.Collections.Generic;
using SherEShop.Server.Common;

namespace SherEShop.Utilities
{
    public interface IOperableCollection
    {
        void AddUser(User user);
        void AddProduct(Product product);
        void AddOrder(int oldUserId, Order newUser);
        IEnumerable<Product> GetAllProducts();
        User GetUser(int id);
    }
}