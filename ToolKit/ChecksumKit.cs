using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit
{
    public static class ChecksumKit
    {
        public static byte XORChecksum(byte[] data)
        {
            byte checksum = 0;
            foreach (byte b in data) 
            {
                checksum ^= b;
            }
            return checksum;
        }

        public static (byte sum1,byte sum2) Fletcher16(byte[] data)
        {
            int sum1 = 0, sum2 = 0;
            const int MOD = 255;

            foreach(byte b in data)
            {
                sum1 = (sum1 + b) % MOD;
                sum2 = (sum2 + sum1) % MOD;
            }

            return ((byte)sum1,  (byte)sum2);
        }
    }
}
