namespace aoc2024.Puzzles;

public abstract class Solution(string day)
{
    public abstract string SolvePartOne();

    public abstract string SolvePartTwo();

    public void Solve()
    {

        Console.WriteLine($"Solution {day}.1: {SolvePartOne()}; Solution {day}.2: {SolvePartTwo()}");
    }
}