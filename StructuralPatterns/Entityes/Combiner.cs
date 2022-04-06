using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

internal class Combiner
{

    public static CommonProduct Convert(object inputItem)
    {

        if (inputItem is Product product)
        {
            return ConvertFromProduct(product);
        }
        else if (inputItem is Furniture furniture)
        {
            return ConvertFromFurniture(furniture);
        }

        else
        {
            throw new ArgumentException("Input type unknown");
        }

    }

    private static CommonProduct ConvertFromProduct(Product product)
    {
        return CommonProduct.New(product.Name, product.Price);
    }

    private static CommonProduct ConvertFromFurniture(Furniture furniture)
    {
        return CommonProduct.New(furniture.Designation, furniture.Price);
    }


}
