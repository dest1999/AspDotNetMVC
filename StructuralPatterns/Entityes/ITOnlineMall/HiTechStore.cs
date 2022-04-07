using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

internal class HiTechStore
{
    private static List<HiTechPart> parts = new();

    public static void Add(HiTechPart part)
    {
        parts.Add(part);
    }

    public static List<HiTechPart> GetParts()
    {
        return parts;
    }


}
