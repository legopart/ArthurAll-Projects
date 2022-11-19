using Client.Services;

namespace PromoterClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(new LoginServices(),new SocialServices(),
                new CampaignServices(),new DonationServices(),new OrderServices(),
                new UsersServices()));
        }
    }
}