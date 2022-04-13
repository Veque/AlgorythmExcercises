using Common;

namespace JobSequencingProblem;

class Solution
{
    //Complete this function
    public int[] JobScheduling(Job[] arr, int n)
    {
        var heap = new Heap<Job>(n, (j1, j2) => j1.profit > j2.profit ? 1 : (j1.profit < j2.profit ? -1 : 0));
        for (int i = 0; i < n; i++)
        {
            heap.Push(arr[i]);
        }

        var jobsCount = 0;
        var totalProfit = 0;

        while (heap.Count > 0)
        {
            var job = heap.Pop();
            if (job.dead >= jobsCount + 1)
            {
                totalProfit += job.profit;
                jobsCount += 1;
            }
        }

        return new int[] { jobsCount, totalProfit };
    }
}