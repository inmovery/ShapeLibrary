using NUnit.Framework;
using ShapeLibrary.Calculators;
using ShapeLibrary.Configurations;
using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests
{
	[TestFixture]
	public class TriangleTests
	{
		private const double AcceptableDelta = 1e-5;

		private static readonly object[] AcceptableTestData =
		{
			new object[]
			{
				ConfigureTriangle(0, 0, 0),
				0
			},
			new object[]
			{
				ConfigureTriangle(3, 4, 5),
				6
			},
			new object[]
			{
				ConfigureTriangle(6,4,5),
				9.921567416492215
			},
			new object[]
			{
				ConfigureTriangle(37, 21, 30.5),
				320.24950600078995
			},
			new object[]
			{
				ConfigureTriangle(102, 15, 91),
				490.5670188669434
			},
			new object[]
			{
				ConfigureTriangle(57, 22, 71),
				534.9766350038102
			}
		};

		private static readonly object[] NotAcceptableTestData =
		{
			ConfigureTriangle(12, 22, 99),
			ConfigureTriangle(11, 0, 56),
			ConfigureTriangle(8, -5, 14),
			ConfigureTriangle(1, 33, 502),
			ConfigureTriangle(64, 23, 32),
			ConfigureTriangle(double.NaN, double.NaN, double.NaN)
		};

		[TestCaseSource(nameof(AcceptableTestData))]
		public void ReturnAcceptableValues(IShape shape, double expectedAreaValue)
		{
			var actualValue = shape.CalculateArea();
			Assert.AreEqual(expectedAreaValue, actualValue, AcceptableDelta);
		}

		[TestCaseSource(nameof(NotAcceptableTestData))]
		public void AreSpecifiedTriangleDoesNotExist(IShape shape)
		{
			var actualValue = shape.CalculateArea();
			Assert.AreEqual(double.NaN, actualValue);
		}

		[Test]
		public void DetermineWhetherTriangleIsRectangular_ReturnTrue()
		{
			var triangle = ConfigureTriangle(3, 4, 5) as Triangle;
			Assert.AreEqual(true, triangle?.IsRectangular);
		}

		[Test]
		public void DetermineWhetherTriangleIsRectangular_ReturnFalse()
		{
			var triangle = ConfigureTriangle(3, 6, 5) as Triangle;
			Assert.AreEqual(false, triangle?.IsRectangular);
		}

		private static IShape ConfigureTriangle(double firstSide, double secondSide, double thirdSide)
		{
			var shapeConfiguration = new TriangleConfiguration(firstSide, secondSide, thirdSide);
			var areaCalculator = new TriangleAreaByThreeSidesCalculator();
			var triangle = new Triangle(shapeConfiguration, areaCalculator);

			return triangle;
		}
	}
}
