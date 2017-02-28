using System;
using System.Collections.Generic;
using LiteDB;
using Microsoft.Extensions.DependencyModel;
using SherEShop.Server.Common;

namespace SherEShop.Utilities
{
    public class LiteWrap : IOperableCollection
    {
        private readonly LiteDatabase _database;

        public LiteCollection<User> Users => _database.GetCollection<User>("users");
        public LiteCollection<Product> Products => _database.GetCollection<Product>("products");

        public LiteWrap()
        {
            _database = new LiteDatabase("shopdb.db");
        }

        public void AddUser(User user)
        {
            if (Users.Exists(usr => usr.Email == user.Email))
                throw new Exception("User already exists");
            Users.Insert(user);
        }

        public void AddProduct(Product product)
        {
            Products.Insert(product);
        }

        //TODO: good to check if user exits
        public void AddOrder(int userId, Order order)
        {
            var user = Users.FindById(userId);
            user.Orders.Add(order);
            Users.Update(user);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Products.Find(Query.All());
        }

        public User GetUser(int id)
        {
            return Users.FindById(id);
        }
    }
}