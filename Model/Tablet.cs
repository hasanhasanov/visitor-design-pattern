using visitor_design_pattern.Interfaces;

namespace visitor_design_pattern.Model
{
    public abstract class Tablet
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Tablet(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void Accept(IVisitor visitor);
    }

    public interface ITablet
    {
        void Accept(IVisitor visitor);
    }
}