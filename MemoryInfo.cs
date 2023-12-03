using System.Management;

namespace VSystem
{
	/// <summary>
	/// Provides information about a memory device.
	/// </summary>
	public struct MemoryInfo
	{
		/// <summary>
		/// The name of the memory device.
		/// </summary>
		public readonly string Name;
		/// <summary>
		/// The manufacturer of the memory device.
		/// </summary>
		public readonly string Manufacturer;
		/// <summary>
		/// The speed of the memory device (In MHz).
		/// </summary>
		public readonly double Speed;
		/// <summary>
		/// The memory type.
		/// </summary>
		public readonly string MemoryType;
		/// <summary>
		/// The form factor of the memory device.
		/// </summary>
		public readonly string FormFactor;
		/// <summary>
		/// The capacity of the memory device (In bytes).
		/// </summary>
		public readonly long Capacity;


		/// <summary>
		/// Creates a new instance of the <see cref="MemoryInfo"/> struct.
		/// </summary>
		/// <param name="value">The <see cref="ManagementBaseObject"/> to analyze.</param>
		public MemoryInfo(ManagementBaseObject value)
		{
			Name=GetStringValue(value, "Name");
			Manufacturer=GetStringValue(value, "Manufacturer");
			Speed=GetDoubleValue(value, "Speed");
			MemoryType=GetStringValue(value, "MemoryType");
			FormFactor=GetStringValue(value, "FormFactor");
			Capacity=GetLongValue(value, "MemoryType");
		}

		private static string GetStringValue(ManagementBaseObject obj, string key) => obj[key].ToString()!;

		private static double GetDoubleValue(ManagementBaseObject obj, string key) => Convert.ToDouble(obj[key]);

		private static long GetLongValue(ManagementBaseObject obj, string key) => Convert.ToInt64(obj[key]);

	}
}
