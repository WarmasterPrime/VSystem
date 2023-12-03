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
		public readonly int Speed;
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
		/// <exception cref="ArgumentNullException"></exception>
		public MemoryInfo(ManagementBaseObject value)
		{
			if(value is null)
				throw new ArgumentNullException(nameof(value));
			Name=value["Name"].ToString()!;
			Manufacturer=value["Manufacturer"].ToString()!;
			Speed=Convert.ToInt32(value["Speed"]);
			MemoryType=value["MemoryType"].ToString()!;
			FormFactor=value["FormFactor"].ToString()!;
			Capacity=Convert.ToInt64(value["Capacity"]);
		}

	}
}
