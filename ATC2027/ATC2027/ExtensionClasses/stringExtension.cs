using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ExtensionClasses
{
    public class stringExtension
    {
        public static string characterReplacer(String str, char itemToReplace, char itemToReplaceWith)
        {
            List<int> indexesToReplace = [];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == itemToReplace)
                    indexesToReplace.Add(i);
            }
            string newStr = "";

            for (int i = 0;i < str.Length; i++)
            {
                if ((str[i] != itemToReplace))
                    newStr += str[i];
                else
                    newStr += itemToReplaceWith;
            }
            return newStr;
        }
        public static string characterReplacer(String str, char itemToReplaceWith)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                newStr += itemToReplaceWith;
            }
            return newStr;
        }
    }
}
