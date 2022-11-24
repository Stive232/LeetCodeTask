using System;
using System.Collections.Generic;

namespace FindIndex
{
  class Program
  {
    static int[] TwoSum(int[] nums, int target)
    {
      int[] result = new int[2];
      var load = new Dictionary<int, int>();
      bool allIsGood = false;

      for (int i = 0; i < nums.Length; i++)
      {
        int secodNumber = target - nums[i];
        if (load.ContainsKey(secodNumber))
        {
          result[0] = i;
          result[1] = load[secodNumber];
          allIsGood = true;
          break;
        }
        if (!load.ContainsKey(nums[i]))
        {
          load.Add(nums[i], i);
        }
      }
      if (allIsGood)
      {
        return result;
      }
      return null;
    }
    static void Main(string[] args)
    {
      int[] array = new int[] { 4, 20, 4, 2, 4, 8, 12, -7 };
      int target = 8;
      int[] result = TwoSum(array, target);
    }
  }
}
