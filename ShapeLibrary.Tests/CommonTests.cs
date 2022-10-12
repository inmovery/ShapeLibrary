using NUnit.Framework;
using ShapeLibrary.Calculators;
using ShapeLibrary.Configurations;
using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests
{
	public class CommonTests
	{
		[Test]
		public void When_Adding_NotSuitableConfigurator_ThrowsInvalidShapeConfigurationException()
		{
			var shapeConfiguration = new CircleConfiguration(0);
			var areaCalculator = new TriangleAreaByThreeSidesCalculator();
			var triangle = new Triangle(shapeConfiguration, areaCalculator);

			Assert.Throws<InvalidShapeConfigurationException>(() => triangle.CalculateArea());
		}

		[Test]
		public void When_Adding_NullAsConfigurator_ThrowsInvalidShapeConfigurationException()
		{
			Assert.Throws<InvalidShapeConfigurationException>(() =>
			{
				var areaCalculator = new TriangleAreaByThreeSidesCalculator();
				var triangle = new Triangle(null, areaCalculator);
			});
		}

		[Test]
		public void When_Adding_NullAsAreaCalculator_ThrowsInvalidShapeConfigurationException()
		{
			Assert.Throws<InvalidAreaCalculatorException>(() =>
			{
				var shapeConfiguration = new CircleConfiguration(0);
				var triangle = new Triangle(shapeConfiguration, null);
			});
		}
	}
}
