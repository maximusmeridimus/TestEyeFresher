using System;
using System.Management;

namespace EyeFresher
{
    class BrightnessWork
    {
        
        public static ushort GetMonitorBrightness()
        {
            using (var mclass = new ManagementClass("WmiMonitorBrightness"))
            {
                mclass.Scope = new ManagementScope(@"\\.\root\wmi");
                using (var instances = mclass.GetInstances())
                {
                    foreach (ManagementObject instance in instances)
                    {
                        return (byte)instance.GetPropertyValue("CurrentBrightness");
                    }
                }
            }
            return 0;
        }

        public static void SetMonitorBrightness(ushort brightness)
        {
            using (var mclass = new ManagementClass("WmiMonitorBrightnessMethods"))
            {
                mclass.Scope = new ManagementScope(@"\\.\root\wmi");
                using (var instances = mclass.GetInstances())
                {
                    foreach (ManagementObject instance in instances)
                    {
                        object[] args = new object[] { 1, brightness };
                        instance.InvokeMethod("WmiSetBrightness", args);
                    }
                }
            }
        }
    }
}
