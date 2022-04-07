using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

internal class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    public DateTime Expires { get; private set; }

    private Product()
    {

    }

    public static Product New(string name, decimal price, int quantity, DateTime expires)
    {
        if (string.IsNullOrWhiteSpace(name) || price <= 0 || quantity <= 0)
        {
            throw new ArgumentException("Init values not correct");
        }
        Product product = new()
        {
            Name = name,
            Price = price,
            Quantity = quantity,
            Expires = expires
        };

        return product;
    }

    public void ChangeQuantity(int deltaQuantity)
    {
        var tmp = Quantity + deltaQuantity;
        if (tmp > 0)
        {
            Quantity = tmp;
        }
        else
        {
            throw new ArgumentException("Not enought minerals");
        }
    }

    public override string ToString()
    {
        return $"{Name}, {Quantity} \t${Price}";
    }
}
