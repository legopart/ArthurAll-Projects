using System;
using System.Collections.Generic;

namespace Singleton.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		var b1 = LoadBalancer.Instance;
		var b2 = LoadBalancer.Instance;
		var b3 = LoadBalancer.Instance;
		var b4 = LoadBalancer.Instance;

		// Confirm these are the same instance
		if (b1 == b2 && b2 == b3 && b3 == b4)
		{
			Console.WriteLine("Same instance\n");
		}

		// Next, load balance 15 requests for a server
		var balancer = LoadBalancer.Instance;
		for (int i = 0; i < 15; i++)
		{
			string serverName = balancer.NextServer.Name;
			Console.WriteLine("Dispatch request to: " + serverName);
		}
	}
}

