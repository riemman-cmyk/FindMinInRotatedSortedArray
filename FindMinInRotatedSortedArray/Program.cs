namespace FindMinInRotatedSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];

            nums[0] = Random.Shared.Next(100);
            for(int i = 1; i < n; i++)
            {
                nums[i] = nums[i - 1] + Random.Shared.Next(100);
            }
            Console.WriteLine(get_min_value_in_rotated_sorted_array(nums));
        }

        static int get_min_value_in_rotated_sorted_array(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;

            while (l < r)
            {
                int k = l + (r - l) / 2;
                if (nums[k] > nums[r])
                {
                    l = k + 1;
                }
                else if (nums[k] < nums[r])
                {
                    r = k;
                }
                else
                {
                    r--;
                }
            }
            return nums[l];
        }
    }
}
