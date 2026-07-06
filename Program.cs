using Pharmacy_Nhom1;

namespace Pharmacy_Nhom1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}