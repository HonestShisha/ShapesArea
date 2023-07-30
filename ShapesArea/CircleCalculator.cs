namespace ShapesArea {

	public class CircleCalculator : IAreaCalculator {
		public double Radius { get; set; }

		public CircleCalculator(double radius) {
			Radius = radius;
		}

		public double Area() {
			return Math.Pow(Radius, 2.0) * Math.PI;
		}
	}
}