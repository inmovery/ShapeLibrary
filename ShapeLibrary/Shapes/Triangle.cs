using System;
using ShapeLibrary.Configurations;
using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes.Base;

namespace ShapeLibrary.Shapes
{
	public class Triangle : BaseShape
	{
		public Triangle(IShapeConfiguration shapeConfiguration, IAreaCalculator areaCalculator) : base(
			shapeConfiguration, areaCalculator)
		{
		}

		public bool IsRectangular => CheckWhetherTriangularIsRectangular();

		private bool CheckWhetherTriangularIsRectangular()
		{
			var triangularConfiguration = ShapeConfiguration as TriangleConfiguration ?? throw new InvalidShapeConfigurationException();

			var firstSide = triangularConfiguration.FirstSide;
			var secondSide = triangularConfiguration.SecondSide;
			var thirdSide = triangularConfiguration.ThirdSide;

			var firstExpressionResult = Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2);
			var secondExpressionResult = Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2) + Math.Pow(firstSide, 2);
			var thirdExpressionResult = Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2);

			var expressionSummary = firstExpressionResult || secondExpressionResult || thirdExpressionResult;
			return expressionSummary;
		}
	}
}
