namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two sum");
            Solution solution = new Solution();
            //var result = solution.TwoSum([2, 7, 11, 15], 9);
            //var result = solution.TwoSum([3, 2, 4], 6);
            //var result = solution.TwoSum([3, 3],6);
            var result = solution.TwoSum([2, 5, 5, 11], 10);
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = null;
            bool spy = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result = [i, j];
                            spy = true;
                            break;
                        }
                    }
                }
                if (spy)
                {
                    break;
                }
            }
            return result;
        }
    }
}
