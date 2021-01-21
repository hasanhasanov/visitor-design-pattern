using System;
using visitor_design_pattern.Model;

namespace visitor_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPad iPad = new IPad("Ipad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("Galaxy Tab", "Samsung");

            iPad.Accept(new WifiVisitor());
            galaxyTab.Accept(new WifiVisitor());

            iPad.Accept(new ThreeGVisitor());
            galaxyTab.Accept(new ThreeGVisitor());

            //* bunun gibi baska visitor sınıfları yazarak sınıfımızı değiştirmeden
            //* yeni metotlar çalıştırabilir hale getirebiliriz. 

            Console.ReadLine();
        }
    }
}
