using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns;

enum PartType
{
    PCPart,
    LANPart,
    PowerSupplyPart,
    Printers,
    Monitors,
    Peripherals
}

internal class HiTechPart
{
    public PartType Classificator { get; private set; }
    public string PartName { get; private set; }
    public string Description { get; private set; }
    public decimal Cost { get; private set; }

    private HiTechPart()
    {

    }

    public static HiTechPart CreatePart(PartType classificator, string partName, decimal cost, string description = "")
    {
        HiTechPart part = new()
        {
            Classificator = classificator,
            PartName = partName,
            Description = description,
            Cost = cost

        };
        return part;
    }



}
