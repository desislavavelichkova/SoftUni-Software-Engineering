using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }

        public override double CalculatePerimeter()
        {
            double p = 2 * (Height + Width);
            return p;
        }
        public override double CalculateArea()
        {
            double p = Width * Height;
            return p;
        }
        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("*");
            for (int i = 1; i < Width - 1; ++i)
            {
                sb.Append("*");
            }
            sb.AppendLine("*");
                        
            for (int i = 1; i < this.Height - 1; ++i)
            {                
                sb.Append("*");
                for (int j = 1; j < Width - 1; ++j)
                {
                    sb.Append(" ");
                }
                sb.AppendLine("*");
            }            
            sb.Append("*");
            for (int i = 1; i < Width - 1; ++i)
            {
                sb.Append("*");
            }
            sb.AppendLine("*");

            return sb.ToString();
        }
    }
}

