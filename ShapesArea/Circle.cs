namespace ShapesArea {

	public class Circle : IShape {
		public double Radius { get; set; }

		public Circle(double radius) {
			Radius = radius;
		}

		public double Area() {
			return Math.Pow(Radius, 2.0) * Math.PI;
		}
	}
}