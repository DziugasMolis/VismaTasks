using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTasks
{
    public class Tasks
    {
        public bool canConstruct(string ransom, string magazine)
        {
            char[] ransomArray = ransom.ToCharArray();
            char[] magazineArray = magazine.ToCharArray();

            int ransomcnt = ransomArray.Length;
            int magazinecnt = magazineArray.Length;

            int[] kiekis = new int[ransomcnt];
            int k = 0;
            if (ransom == null || magazine == null)
                return false;

            if (ransomcnt > magazinecnt)
                return false;

            for (int i = 0; i < ransomcnt; i++)
            {

                for (int j = i; j < magazinecnt; j++)
                {
                    if (ransomArray[i].Equals(magazineArray[j]))
                    {
                        k++;
                        break;
                    }
                }
            }
            if (k == ransomcnt)
                return true;

            return false;

        }
        public int[] Zeros(int[] nums)
        {

            int positivenmb = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {


                    if (nums[positivenmb] != nums[i])
                        nums[positivenmb] = nums[i];
                    positivenmb++;
                }
            }
            int zeroscnt = nums.Length - positivenmb;
            if (zeroscnt != 0)
            {
                for (int i = 0; i < zeroscnt; i++)
                {
                    nums[nums.Length - i - 1] = 0;
                }
            }
            return nums;
        }
    }
}
