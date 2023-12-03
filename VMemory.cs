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
		public VMemory()
		{
			var list=VSystem.Get("SELECT * FROM Win32_PhysicalMemory");
			MemoryInfo[] res=Array.Empty<MemoryInfo>();
			foreach(var sel in list)
			{
				Array.Resize(ref res, res.Length+1);
				res[^1]=new(sel);
			}
			Items=res;
		}

	}
}
