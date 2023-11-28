using XIIRPL1_25_Ticketing.MasterForm;

namespace XIIRPL1_25_Ticketing
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

            //FrmMasterBandara bandara = new FrmMasterBandara();
            //bandara.Show();

            //Master_Maskapai maskapai = new Master_Maskapai();
            //maskapai.Show();

            //FrmMasterKodePromo kodepromo = new FrmMasterKodePromo();
            //kodepromo.Show();

            FrmMasterJadwalPenerbangan jadwalpenerbangan = new FrmMasterJadwalPenerbangan();
            jadwalpenerbangan.Show();

            Application.Run();
        }
    }
}