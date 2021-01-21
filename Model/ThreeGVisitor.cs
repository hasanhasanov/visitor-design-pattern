using System;
using visitor_design_pattern.Interfaces;

namespace visitor_design_pattern.Model
{
    public class ThreeGVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("Ipad wifi does not have 3G option.");
            else if (tablet is GalaxyTab)
                Console.WriteLine("GalaxyTab 3G has open.");
            else
                Console.WriteLine("This object is not a tablet.");
        }
    }
}