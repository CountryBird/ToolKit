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

        public static string Truncate(string input, int maxLength, string suffix = "...") // 문자열 자르기, 이후는 suffix로 대체 (기본값: ...)
        {
            if (string.IsNullOrEmpty(input) || maxLength < 0) return input;
            return input.Length > maxLength?
                input.Substring(0, maxLength) + suffix : input;
        }

        #region Naming Convention

        public static string ToPascalCase(string input) // PascalCase 변환: 단어 첫 글자 대문자
        {
            if (string.IsNullOrEmpty(input)) return input;

            TextInfo ti = CultureInfo.InvariantCulture.TextInfo;

            var words = input.Split(new []{ ' ','-','_'}, StringSplitOptions.RemoveEmptyEntries);

            var sb = new StringBuilder();
            foreach(var word in words)
            {
                sb.Append(ti.ToUpper(word[0]));
                if (word.Length > 1) sb.Append(word.Substring(1));
            }

            return sb.ToString();
        }
        public static string ToCamelCase(string input) // camelCase 변환: 첫 단어 첫 글자만 소문자, 이외의 단어 첫 글자 대문자
        {
            var pascal = ToPascalCase(input);

            if(string.IsNullOrEmpty(pascal)) return pascal;

            return char.ToLowerInvariant(pascal[0]) + pascal.Substring(1);
        }
        public static string ToSnakeCase(string input) // snake_case 변환: 모든 단어 소문자, 단어 사이를 _로 연결
        {
            if(string.IsNullOrEmpty(input)) return input;

            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsUpper(c))
                {
                    if (i > 0) sb.Append('_');
                    sb.Append(char.ToLowerInvariant(c));
                }
                else sb.Append(c);
            }
            return sb.ToString();
        }
        public static string ToKebabCase(string input) // kebab-case 변환: 모든 단어 소문자, 단어 사이를 -로 연결
        {
            if(string.IsNullOrEmpty (input)) return input;

            var sb = new StringBuilder();
            for(int i = 0;i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsUpper(c))
                {
                    if(i>0) sb.Append("-");
                    sb.Append(char.ToLowerInvariant(c));
                }
                else sb.Append(c);
            }
            return sb.ToString();
        }

        #endregion
    }
}
