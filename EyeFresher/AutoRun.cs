using System;


namespace EyeFresher
{
    public class AutoRun
    {
        const string name = "MyApplication";
        static bool autorun = Properties.Settings.Default.AutoRun;
        static Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(
                "Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

        public static void AddToAutorun()
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            try
            {

                reg.SetValue(name, ExePath);

                reg.Close();

            }
            catch (Exception ex) {  }
        }

        public static void DeleteFromAutorun()
        {
            try
            {
                reg.DeleteValue(name);
                reg.Close();

            }
            catch { }
        }
            
    }
}
