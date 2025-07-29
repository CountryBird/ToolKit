using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO.Ports;

namespace ToolKit
{
    public static class CheckKit
    {
        public static bool IsSame<T>(T? item1, T? item2) // 두 객체가 같은지 비교
        {
            if(item1 == null && item2 == null) return true;
            if(item1 == null || item2 == null) return false;

            return Equals(item1, item2);
        }
        public static bool IsValidIPAdress(string input) // 유효한 IP 주소인지 확인
        {
            return IPAddress.TryParse(input, out _);
        }
        public static bool IsValidSerialAddress(string input) // 유효한 Serial 주소인지 확인
        {
            var availablePorts = SerialPort.GetPortNames();
            return availablePorts.Contains(input.ToUpper());
        }
    }
}
