using System;
using UnityEngine;

namespace Plugins.ClassExtensions.CsharpExtensions {
	public static class FloatExtensions {
		public static float Round(this float number, int decimalPlaces) {
			return (float) Math.Round(number, decimalPlaces);
		}

		public static bool GetIsBetween(this float value, float min, float max, bool inclusive = true) {
			return inclusive && value >= min && value <= max ||
			       !inclusive && value > min && value < max;
		}

		public static float GetNearest(this float value, float test1, float test2) {
			float absValue = Mathf.Abs(value);
			float absTest1 = Mathf.Abs(test1);
			float absTest2 = Mathf.Abs(test2);

			float difference1 = Mathf.Abs(absTest1 - absValue);
			float difference2 = Mathf.Abs(absTest2 - absValue);

			if (difference1 <= difference2) {
				return test1;
			}

			return test2;
		}
	}
}