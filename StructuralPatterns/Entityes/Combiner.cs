using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        else if (inputItem is HiTechPart hiTechPart)
        {
            return ConvertFromHiTechPert(hiTechPart);
        }

        else
        {
            throw new ArgumentException("Input type unknown");
        }
    }

    public static List<CommonProduct> Convert(IEnumerable<object> inputList)
    {
        var products = new List<CommonProduct>();
        foreach (object inputItem in inputList)
        {
            try
            {
                products.Add(Convert(inputItem));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
        return products;
    }

    private static CommonProduct ConvertFromHiTechPert(HiTechPart hiTechPart)
    {
        return CommonProduct.New(hiTechPart.PartName, hiTechPart.Cost);
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
