using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text.Json;

namespace Prototype.Sample1
{

    class Program
	{
		static void Main()
		{
			var mgr = new WindowManager();
			var win = mgr.CreateUI();
			win.Dump();
		}

		public static object? DeepCopy(object prototype)
		{
			using (var stm = new MemoryStream())
			{
				var formatter = new BinaryFormatter();
				formatter.Serialize(stm, prototype);
				stm.Position = 0;
				return formatter.Deserialize(stm);
			}
		}
	}

}
