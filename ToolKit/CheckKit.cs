using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
