using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTasks
{
    public class Tasks
    {
        public bool CanConstruct(string ransom, string magazine)
        {
            if(ransom == null || magazine == null)
                return false;

            char[] ransomArray = ransom.ToCharArray();
            char[] magazineArray = magazine.ToCharArray();

            int ransomCount = ransomArray.Length;
            int magazineCount = magazineArray.Length;

            int k = 0;
           

            if (ransomCount > magazineCount)
                return false;

            for (int i = 0; i < ransomCount; i++)
            {

                for (int j = i; j < magazineCount; j++)
                {
                    if (ransomArray[i].Equals(magazineArray[j]))
                    {
                        k++;
                        break;
                    }
                }
            }
            if (k == ransomCount)
                return true;

            return false;

        }
        public int[] Zeros(int[] nums)
        {

            int positiveNumber = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {


                    if (nums[positiveNumber] != nums[i])
                        nums[positiveNumber] = nums[i];
                    positiveNumber++;
                }
            }
            int zerosCount = nums.Length - positiveNumber;
            if (zerosCount != 0)
            {
                for (int i = 0; i < zerosCount; i++)
                {
                    nums[nums.Length - i - 1] = 0;
                }
            }
            return nums;
        }
    }
}
