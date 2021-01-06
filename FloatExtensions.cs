using System;

namespace __Utils._ClassExtensions.LanguageExtensions {
	public static class FloatExtensions {
		public static float Round(this float number, int decimalPlaces) {
			return (float) Math.Round(number, decimalPlaces);
		}
	}
}