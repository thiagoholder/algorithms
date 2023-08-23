namespace ArrayManipulation
{
    class Program{
    static void Main(string[] args)
    {
      int[] nums = {1,2,3,4,5};
      int k = 2;

      Console.WriteLine("Original Array: ");
      DisplayArray(nums);

      Rotate(nums, k);

      Console.WriteLine($"\nArray after {k} rotations:");
      DisplayArray(nums);

    }

    static void Rotate(int[] nums, int k)
    {
      if(nums == null || nums.Length < 2)
        return;
      
      k %= nums.Length;
      Reverse(nums, 0, nums.Length -1);
      Reverse(nums, 0, k - 1);
      Reverse(nums, k, nums.Length -1);
    }

    public static void Reverse(int[] nums, int start, int end)
    {
      while (start < end)
      {
        int temp = nums[start];
        nums[start] = nums[end];
        nums[end] = temp;
        start ++;
        end--;
      }
    }



    static void DisplayArray(int[] nums)
    {
      Console.WriteLine(string.Join(", ", nums));
    }

  }
}