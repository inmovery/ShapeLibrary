using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes.Base;

namespace ShapeLibrary.Shapes
{
	public class Circle : BaseShape
	{
		public Circle(IShapeConfiguration shapeConfiguration, IAreaCalculator areaCalculator) : base(shapeConfiguration, areaCalculator)
		{
		}
	}
}
