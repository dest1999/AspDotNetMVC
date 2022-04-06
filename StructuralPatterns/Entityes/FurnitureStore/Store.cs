using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;
internal class Store
{
    private static List<Furniture> furnitures = new();

    public static void Add(Furniture furniture)
    {
        furnitures.Add(furniture);
    }

    public static List<Furniture> GetAll()
    {
        return furnitures;
    }

}
