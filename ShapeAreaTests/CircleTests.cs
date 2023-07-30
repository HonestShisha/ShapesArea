using ShapesArea;
namespace ShapeAreaTests {
	public class CircleTests {
		[Theory()]
		[InlineData(0.0, 0)]
		[InlineData(4.0, 50.26548245743669)]
		public void Circle_area(double radius, double expected) {
			var sut = new Circle(radius);

			var result = sut.Area();

			Assert.Equal(expected, result);
		}
	}
}