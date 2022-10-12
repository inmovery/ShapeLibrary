using System.Windows.Input;
using ShapeLibrary.Calculators;
using ShapeLibrary.Configurations;
using ShapeLibrary.Demo.Commands;
using ShapeLibrary.Demo.ViewModels.Base;
using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Demo.ViewModels
{
	public class MainWindowViewModel : BaseViewModel
	{
		public MainWindowViewModel()
		{
			CalculateAreaCommand = new RelayCommand(ExecuteCalculateAreaCommand);
		}

		public ICommand CalculateAreaCommand { get; }

		private void TestShapes()
		{
			var radius = 5;
			var circleConfiguration = new CircleConfiguration(radius);
			var circleAreaByRadiusCalculator = new CircleAreaByRadiusCalculator();

			var circle = new Circle(circleConfiguration, circleAreaByRadiusCalculator);
			var circleArea = circle.CalculateArea();

			var firstSide = 3;
			var secondSide = 4;
			var thirdSide = 5;
			var triangleConfiguration = new TriangleConfiguration(firstSide, secondSide, thirdSide);
			var triangleAreaByThreeSidesCalculator = new TriangleAreaByThreeSidesCalculator();

			var triangle = new Triangle(triangleConfiguration, triangleAreaByThreeSidesCalculator);
			var triangleArea = triangle.CalculateArea();
			var isTriangularShape = triangle.IsRectangular;
		}

		private void ExecuteCalculateAreaCommand()
		{
			TestShapes();
		}
	}
}
