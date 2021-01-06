namespace __Utils._ClassExtensions.LanguageExtensions {
	public static class ObjectExtensions {
		public static bool IsReallyNull(this object obj) {
			return obj == null || obj.Equals(null);
		}
	}
}