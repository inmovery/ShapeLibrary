using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes.Base
{
	public class BaseShape : IShape
	{
		protected readonly IShapeConfiguration ShapeConfiguration;
		protected readonly IAreaCalculator AreaCalculator;

		protected BaseShape(IShapeConfiguration shapeConfiguration, IAreaCalculator areaCalculator)
		{
			ShapeConfiguration = shapeConfiguration ?? throw new InvalidShapeConfigurationException();
			AreaCalculator = areaCalculator ?? throw new InvalidAreaCalculatorException();
		}

		public double CalculateArea()
		{
			var circleArea = AreaCalculator.Calculate(ShapeConfiguration);
			var validatedArea = circleArea >= 0 ? circleArea : double.NaN;

			return validatedArea;
		}
	}
}
