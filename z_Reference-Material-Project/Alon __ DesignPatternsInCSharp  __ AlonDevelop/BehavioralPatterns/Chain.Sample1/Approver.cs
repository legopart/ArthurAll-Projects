namespace Chain.Sample1;

// The 'Handler' abstract class
abstract class Approver
{
	public abstract void ProcessRequest(Purchase purchase);

	// Sets or gets the next approver
	public Approver? Successor { get; set; }
}

