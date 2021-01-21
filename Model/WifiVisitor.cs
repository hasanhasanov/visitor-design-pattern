using System;
using visitor_design_pattern.Interfaces;

namespace visitor_design_pattern.Model
{
    public class WifiVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("IPad fiwi has been open");
            else if (tablet is GalaxyTab)
                Console.WriteLine("GalaxyTab does not have wifi option.");
            else
                Console.WriteLine("This object is not a tablet.");
        }
    }
}