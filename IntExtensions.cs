namespace __Utils._ClassExtensions.LanguageExtensions {
	public static class IntExtensions {
		public static bool IsValidIndex(this int i, int length) {
			return i >= 0 && i < length;
		}
	}
}