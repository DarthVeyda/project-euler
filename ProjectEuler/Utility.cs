using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    internal static class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string PrettyPrint(List<long> array)
        {
            return string.Join(", ", array);
        }
    }
}