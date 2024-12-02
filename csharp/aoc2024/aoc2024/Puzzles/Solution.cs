namespace aoc2024.Puzzles;

public abstract class Solution
{
    private readonly string _day;
    protected Solution(string day)
    {
        _day = day;
    }

    public abstract string SolvePartOne();

    public abstract string SolvePartTwo();

    public void Solve()
    {

        Console.WriteLine($"Solution {_day}.1: {SolvePartOne()}; Solution {_day}.2: {SolvePartTwo()}");
    }
}