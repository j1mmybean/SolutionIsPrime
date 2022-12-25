using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class ClassIsPrime
    {
        /// <summary>
        /// 判斷一正整數是否為質數，是質數及傳回true，不是則傳回false
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(this int number)
        {
            //先將1排除
            if (number < 2) return false;

            //利用如果ab=n，則a or b < n^(1/2)，判斷一正整數n>2是否為質數
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0) return false;
            }
            return true;
        }


    }
}
