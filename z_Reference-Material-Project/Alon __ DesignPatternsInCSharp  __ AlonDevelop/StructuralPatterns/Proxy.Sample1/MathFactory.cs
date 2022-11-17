namespace Proxy.Sample1
{

	static class MathFactory
	{
		public static IMath GetMath()
		{
			return new MathProxy();
		}
	}

}