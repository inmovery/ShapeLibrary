using System;
using ShapeLibrary.Configurations;
using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Calculators
{
	public class CircleAreaByRadiusCalculator : IAreaCalculator
	{
		public double Calculate(IShapeConfiguration shapeConfiguration)
		{
			var circleConfiguration = shapeConfiguration as CircleConfiguration ?? throw new InvalidShapeConfigurationException();
			var equationResult = Math.PI * Math.Pow(circleConfiguration.Radius, 2);

			return equationResult;
		}
	}
}
