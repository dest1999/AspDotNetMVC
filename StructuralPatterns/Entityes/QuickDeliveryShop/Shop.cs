using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

internal class Shop
{
    private static Dictionary<string, Product> products = new();

    public static void AddProduct(Product product)
    {//заводим новую позицию или добавляем кол-во в уже существующей
        if (!products.TryAdd(product.Name, product))
        {
            products[product.Name].ChangeQuantity(product.Quantity);
        }
    }

    public static void ChangeQuantity(string productName, int quantity)
    {
        products[productName].ChangeQuantity(quantity);
    }

    public static List<Product> GetAll() => products.Select(p => p.Value).ToList();






}
