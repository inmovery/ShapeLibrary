using System;
using NUnit.Framework;
using ShapeLibrary.Calculators;
using ShapeLibrary.Configurations;
using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests
{
	[TestFixture]
	public class CircleTests
	{
		private const double AcceptableDelta = 1e-5;

		private static readonly object[] AcceptableTestData =
		{
			new object[]
			{
				ConfigureCircle(0),
				0
			},
			new object[]
			{
				ConfigureCircle(1),
				Math.PI
			},
			new object[]
			{
				ConfigureCircle(19),
				1134.114948
			},
			new object[]
			{
				ConfigureCircle(49),
				7542.963961
			},
			new object[]
			{
				ConfigureCircle(3.9),
				47.783624
			},
			new object[]
			{
				ConfigureCircle(17.8),
				995.382216
			}
		};

		private static readonly object[] NotAcceptableTestData =
		{
			ConfigureCircle(-5),
			ConfigureCircle(double.NaN)
		};

		[TestCaseSource(nameof(AcceptableTestData))]
		public void ReturnAcceptableValues(IShape shape, double expectedAreaValue)
		{
			var actualValue = shape.CalculateArea();
			Assert.AreEqual(expectedAreaValue, actualValue, AcceptableDelta);
		}

		[TestCaseSource(nameof(NotAcceptableTestData))]
		public void AreSpecifiedCircleDoesNotExist(IShape shape)
		{
			var actualValue = shape.CalculateArea();
			Assert.AreEqual(double.NaN, actualValue);
		}

		private static IShape ConfigureCircle(double radius)
		{
			var shapeConfiguration = new CircleConfiguration(radius);
			var areaCalculator = new CircleAreaByRadiusCalculator();
			var triangle = new Circle(shapeConfiguration, areaCalculator);

			return triangle;
		}
	}
}
