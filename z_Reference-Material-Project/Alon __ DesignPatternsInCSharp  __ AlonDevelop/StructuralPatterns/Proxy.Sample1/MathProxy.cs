using System;

namespace Proxy.Sample1
{

	// The remote 'Proxy Object' class
	class MathProxy : IMath
	{
		private Math _math;

		public MathProxy()
		{
			// Create Math instance in a different AppDomain
			var ad = AppDomain.CreateDomain("MathDomain", null, null);
			_math = (Math)ad.CreateInstanceAndUnwrap(typeof(Math).Assembly.FullName, typeof(Math).FullName);
		}

		public double Add(double x, double y)
		{
			return _math.Add(x, y);
		}

		public double Sub(double x, double y)
		{
			return _math.Sub(x, y);
		}

		public double Mul(double x, double y)
		{
			return _math.Mul(x, y);
		}

		public double Div(double x, double y)
		{
			return _math.Div(x, y);
		}
	}
}

