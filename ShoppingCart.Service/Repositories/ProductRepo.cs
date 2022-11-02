using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Models;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;

namespace ShoppingCart.Service.Repositories
{
  public class ProductRepo : IProduct
  {
    private readonly ApplicationDbContext _context;

    public ProductRepo(ApplicationDbContext context)
    {
      _context = context;
    }

    public void DeleteProduct(Product product)
    {
      _context.Products.Remove(product);
    }

    public List<Product> GetAllProducts()
    {
      return _context.Products.ToList();
    }

    public Product GetProductById(int Id)
    {
      return _context.Products.Include(x=>x.Categories).ThenInclude(y=>y.Category).Where(x=>x.id==Id).FirstOrDefault();
    }

    public void InsertProduct(Product product)
    {
      _context.Products.Add(product);
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
      _context.Products.Update(product);
    }
  }
}