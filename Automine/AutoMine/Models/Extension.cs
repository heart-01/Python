using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Models
{
    public class Extension
    {

        //string urlBypass = "http://191.96.36.216:3000";
        //string urlNonce = "http://191.96.36.216:4500";
        public static bool Check_HDD(string key_input)
        {
            string drive = "C";
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
            disk.Get();
            string key_drive = disk["VolumeSerialNumber"].ToString();
            if (key_drive != key_input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string HHD_Key()
        {
            string drive = "C";
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }
    }
}
