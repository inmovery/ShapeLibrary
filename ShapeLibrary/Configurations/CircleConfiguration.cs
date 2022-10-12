using ShapeLibrary.Configurations.Base;

namespace ShapeLibrary.Configurations
{
	public class CircleConfiguration : BaseConfiguration
	{
		public CircleConfiguration(double radius)
		{
			Radius = radius >= 0 ? radius : double.NaN;
		}

		public double Radius { get; set; }
	}
}
