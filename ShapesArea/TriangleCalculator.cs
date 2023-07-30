namespace ShapesArea {

	public class TriangleCalculator : IAreaCalculator {
		public double[] SidesLengths { get; set; }

		/// <param name="sidesLengths">Массив из 3 элементов, содержащий длины сторон треугольника</param>
		/// <exception cref="Exception">Если длина массива не соответствует 3, или стороны не могут составить треугольник - будет сгенерировано исключение</exception>
		public TriangleCalculator(double[] sidesLengths) {
			if (sidesLengths.Length != 3) {
				throw new Exception($"{nameof(sidesLengths)} должна содержать ровно три элемента.");
			}

			if (!IsValidTriangle(sidesLengths)) {
				throw new Exception("Сумма длин сторон двух треугольника оказалась меньше длины третьей стороны.");
			}

			SidesLengths = sidesLengths;
		}

		public double Area() {
			if (IsRightTriangle(SidesLengths)) {
				return RightTriangleArea();
			}
			var a = SidesLengths[0];
			var b = SidesLengths[1];
			var c = SidesLengths[2];

			double P = (a + b + c) / 2;
			double area = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

			return area;
		}

		/// <summary>
		/// Определяет прямоугольный ли треугольник
		/// </summary>
		/// <param name="sidesLengths">Массив из 3 элементов, содержащий длины сторон треугольника</param>
		public static bool IsRightTriangle(double[] sidesLengths) {
			var a = sidesLengths[0];
			var b = sidesLengths[1];
			var c = sidesLengths[2];

			var Lab = a * a + b * b;
			var Lbc = b * b + c * c;
			var Lca = c * c + a * a;

			return Lab == c * c || Lbc == a * a || Lca == b * b;
		}

		private static bool IsValidTriangle(double[] sidesLengths) {
			var a = sidesLengths[0];
			var b = sidesLengths[1];
			var c = sidesLengths[2];

			return a + b > c && b + c > a && c + a > b;
		}

		private double RightTriangleArea() {
			var sides = SidesLengths
				.OrderBy(length => length)
				.ToArray();
			double a = sides[0];
			double b = sides[1];

			double area = a * b / 2;

			return area;
		}
	}
}