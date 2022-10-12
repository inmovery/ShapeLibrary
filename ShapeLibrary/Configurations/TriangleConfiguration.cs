using ShapeLibrary.Configurations.Base;

namespace ShapeLibrary.Configurations
{
	public class TriangleConfiguration : BaseConfiguration
	{
		public TriangleConfiguration(double firstSide, double secondSide, double thirdSide)
		{
			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		public double FirstSide { get; set; }

		public double SecondSide { get; set; }

		public double ThirdSide { get; set; }
	}
}
