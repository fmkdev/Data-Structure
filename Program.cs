// See https://aka.ms/new-console-template for more information
//max difference value between the adjacent value of an array.
int[] nums = {-14, 15, -15};
Console.WriteLine(FindMaxDifference(nums));
static int FindMaxDifference(int[] nums)
{
    int maxValue = 0;
    for (int j = 0; j < nums.Length; j++)
    {
        for(int i = j + 1; i < nums.Length;)
        {
            int check = (nums[j] - nums[i]);
            int check1 = (nums[i] - nums[j]);
            if(check > check1)
            {
                if(check > maxValue) maxValue = check;
                break;
            }
            else
            {
                if(check1 > maxValue) maxValue = check;
                break;
            }
        }
    }
    return maxValue;
}