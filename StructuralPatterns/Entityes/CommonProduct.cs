using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

internal class CommonProduct
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    private CommonProduct()
    {

    }

    public static CommonProduct New(string name, decimal price)
    {
        CommonProduct product = new();
        product.Name = name;
        product.Price = price;
        return product;
    }

    public override string ToString()
    {
        return $"{Name}, {Price}";
    }
}
