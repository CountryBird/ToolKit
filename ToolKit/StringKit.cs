using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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
    }
}
