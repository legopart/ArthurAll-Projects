using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Prototype.Sample1
{
	[Serializable]
	class Border : Widget
	{
		Widget? _content;

		public Border(Widget content)
		{
			_content = content;
		}

		public override Widget? Clone()
		{
			// make a deep copy
			Widget clone = null;
			using (var stm = new MemoryStream())
			{
				var formatter = new BinaryFormatter();
				formatter.Serialize(stm, this);
				stm.Position = 0;
				clone = (Widget)formatter.Deserialize(stm);
			}
			return clone;
		}

		public override string ToString()
		{
			return string.Format("Border ID={0}, Width={1}, Height={2}\n\tContent={3}",
				ID, Width, Height, _content);
		}
	}

}
