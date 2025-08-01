using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO.Ports;
using System.Text.RegularExpressions;

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
        public static bool IsExist<T>(T[]? items, T? value) where T : IEquatable<T> // 배열 중 특정 값이 존재하는지 확인
        {
            if(items == null) return false;

            foreach(T item in items) if(item.Equals(value)) return true;

            return false;
        }
        public static bool InRange<T>(T item1, T item2, T? value) where T : IComparable<T> // 특정 값이 다른 특정 두 값 사이에 존재하는지 확인
        {
            if(value ==  null) return false;

            if (item1.CompareTo(item2) <= 0)
                return (item1.CompareTo(value) <= 0) && (value.CompareTo(item2) <= 0);
            else
                return (item2.CompareTo(value) <= 0) && (value.CompareTo(item1) <= 0);
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
        public static bool IsValidMacAddress(string input) // 유효한 MAC 주소인지 확인
        {
            string pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$|^([0-9A-Fa-f]{4}\.){2}([0-9A-Fa-f]{4})$";
            return Regex.IsMatch(input,pattern);
        }
    }
}
