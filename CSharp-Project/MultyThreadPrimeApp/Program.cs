namespace MultyThreadApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PrimeCalculator_MultiThread());
        }
    }
}