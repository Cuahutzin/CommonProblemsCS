using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exercise01.Extensions
{
    public static class CommonStringExtensionscs
    {
        /// <summary>
        /// Reverse string, do an inverted char string loop and append each char to
        /// StringBuilder object and return it as string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseStringBuilder(this string str)
        {
            StringBuilder a = new StringBuilder();
            for (int i = str.Length-1;i >=0; --i  ) {
                a.Append(str[i]);
            }
            return a.ToString();
        }
        /// <summary>
        /// Reverse string, convert to charr array, Reverse the array and retirn it as string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseStringArray(this string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        /// <summary>
        /// Reverse string, do an inverted char string loop and pass each char 
        /// to char array and return it as string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseStringDirectArray(this string str)
        {
            char[] array = new char[str.Length];
            
            for (int i = str.Length - 1, forward = 0; i >= 0; --i,++forward)
            {
                array[forward] = str[i];
            }
            return new string(array);
        }
    }
}
