using System.Collections.Generic;

namespace __Utils._ClassExtensions.LanguageExtensions {
	public static class ListExtensions {
		public static bool IsNullOrEmpty<T>(this List<T> list) {
			return list == null || list.Count == 0;
		}

		public static void Replace<T>(this List<T> list, T current, T replacement) {
			int index = list.IndexOf(current);
			if (index >= 0) {
				list[index] = replacement;
			}
		}
	}
}