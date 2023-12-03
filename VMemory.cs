using System.Collections.Generic;
using System.Management;

namespace VSystem
{
	/// <summary>
	/// Stores memory information.
	/// </summary>
	public struct VMemory
	{
		/// <summary>
		/// The memory devices.
		/// </summary>
		public readonly MemoryInfo[] Items;


		/// <summary>
		/// Creates a new instance of the <see cref="VMemory"/> struct.
		/// </summary>
		public VMemory() => Items=GetInfo(VSystem.Get("SELECT * FROM Win32_PhysicalMemory"));

		private static MemoryInfo[] GetInfo(ManagementObjectCollection obj)
		{
			MemoryInfo[] res=Array.Empty<MemoryInfo>();
			foreach(var sel in obj)
			{
				Array.Resize(ref res, res.Length+1);
				res[^1]=new(sel);
			}
			return res;
		}

	}
}
