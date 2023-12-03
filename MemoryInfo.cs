using System.Management;

namespace VSystem
{
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
