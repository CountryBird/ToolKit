using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToolKit
{
    public static class StringKit
    {
        public static string ToTitleCase(string input) // 첫 글자 대문자
        {
            if(string.IsNullOrWhiteSpace(input)) return input;
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }
        public static string GetSafeFileName(string input) // 파일명에 쓸 수 없는 문자 제거
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return string.Join('_',input.Split(invalidChars,StringSplitOptions.RemoveEmptyEntries)).Trim('.');
        }
        public static string RemoveAllWhitespace(string input) // 공백 제거
        {
            if(string.IsNullOrEmpty(input)) 
                return input;
            return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }
        public static string NormalizeWhitespace(string input) // 여러 공백은 하나로 줄이기
        {
            if (string.IsNullOrEmpty(input))
                return input;
            return Regex.Replace(input, @"\s+", " ").Trim();
        }

        public static string Truncate(string input, int maxLength, string suffix = "...") // 문자열 자르기 (이후는 suffix로 대체)
        {
            if (string.IsNullOrEmpty(input) || maxLength < 0) return input;
            return input.Length > maxLength?
                input.Substring(0, maxLength) + suffix : input;
        }
    }
}
