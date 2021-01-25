using System;

namespace Plugins.ClassExtensions.CsharpExtensions {
	public static class FloatExtensions {
		public static float Round(this float number, int decimalPlaces) {
			return (float) Math.Round(number, decimalPlaces);
		}
	}
}