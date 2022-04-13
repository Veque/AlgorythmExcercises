// See https://aka.ms/new-console-template for more information

using JobSequencingProblem;

var solution = new Solution();

var jobs = new[]
{
    new Job
    {
        id = 1,
        dead = 4,
        profit = 20,
    },
    new Job
    {
        id = 2,
        dead = 1,
        profit = 10,
    },
    new Job
    {
        id = 3,
        dead = 1,
        profit = 40,
    },
    new Job
    {
        id = 4,
        dead = 1,
        profit = 30,
    },
};
var result = solution.JobScheduling(jobs, 4);

Console.WriteLine($"{result[0]} {result[1]}");