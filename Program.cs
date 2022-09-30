using NewCodeChallenge004;

int[] nums = { 2, 7, 11, 15 };
int target = 13;

Target hi = new Target();

int[] output = hi.TwoSum(nums, target);

foreach (var item in output)
{
    Console.WriteLine(item);
}
