using System;
using ShapeLibrary.Configurations;
using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Calculators
{
	public class TriangleAreaByThreeSidesCalculator : IAreaCalculator
	{
		public double Calculate(IShapeConfiguration shapeConfiguration)
		{
			var triangleConfiguration = shapeConfiguration as TriangleConfiguration ?? throw new InvalidShapeConfigurationException();

			var firstSide = triangleConfiguration.FirstSide;
			var secondSide = triangleConfiguration.SecondSide;
			var thirdSide = triangleConfiguration.ThirdSide;

			var perimeter = (firstSide + secondSide + thirdSide) / 2;
			var rootExpression = perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide);

			var equationResult = Math.Sqrt(rootExpression);

			return equationResult;
		}
	}
}
