using System;

namespace Proxy.Sample1
{

	// The 'RealSubject' class
	class Math : MarshalByRefObject, IMath
	{
		public double Add(double x, double y) { return x + y; }
		public double Sub(double x, double y) { return x - y; }
		public double Mul(double x, double y) { return x * y; }
		public double Div(double x, double y) { return x / y; }
	}
}

