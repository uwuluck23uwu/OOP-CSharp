﻿namespace P06_Interface
{
    //Add Edit Delete Search
    public interface IProductManagement
    {
        void AddProcuct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductByAny(int number, string keyword);
    }
}
