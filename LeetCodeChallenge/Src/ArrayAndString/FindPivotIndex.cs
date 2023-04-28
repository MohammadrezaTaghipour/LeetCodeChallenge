namespace ArrayAndString;

public class PivotIndexSolution
{
    public int PivotIndex(int[] nums)
    {
        //Find the total sum of all numbers
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];

        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum -= nums[i];
            if (sum == temp)
                return i;
            temp += nums[i];
        }
        return -1;
    }
}