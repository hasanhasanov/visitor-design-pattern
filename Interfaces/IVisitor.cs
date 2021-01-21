using visitor_design_pattern.Model;

namespace visitor_design_pattern.Interfaces
{
    public interface IVisitor
    {
         void Visit(Tablet tablet);
    }
}