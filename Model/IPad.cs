using visitor_design_pattern.Interfaces;

namespace visitor_design_pattern.Model
{
    public class IPad : Tablet
    {
        public IPad(string brand, string model) : base(brand, model)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}