using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    public static class Extensions
    {
        public static T [] AddToArray<T>(this T [] array, T element)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] != null)
                {
                    continue;
                }
                array[index] = element;
                break;
            }
            return array;
        }
    }
}
