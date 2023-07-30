using ShapesArea;

namespace ShapeAreaTests {

	public class TriangleTests {

		[Theory()]
		[InlineData(new[] { 10.0, 16.0, 9.0 }, 40.907670429883929)]
		[InlineData(new[] { 3.0, 4.0, 5.0 }, 6.0)]
		public void Triangle_area(double[] sidesLengths, double expected) {
			var sut = new TriangleCalculator(sidesLengths);

			var result = sut.Area();

			Assert.Equal(expected, result);
		}

		[Theory()]
		[InlineData(new[] { 10.0, 16.0, 9.0 }, false)]
		[InlineData(new[] { 3.0, 4.0, 5.0 }, true)]
		public void Can_distinguish_right_triangle(double[] sidesLengths, bool expected) {
			var result = TriangleCalculator.IsRightTriangle(sidesLengths);

			Assert.Equal(result, expected);
		}
	}
}