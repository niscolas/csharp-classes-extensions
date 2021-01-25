namespace Plugins.ClassExtensions.CsharpExtensions {
	public static class ObjectExtensions {
		public static bool IsReallyNull(this object obj) {
			return obj == null || obj.Equals(null);
		}
	}
}