using aoc2024.Puzzles;
using aoc2024.Puzzles.Day1;
using aoc2024.Puzzles.Day2;
using aoc2024.Puzzles.Day3;

List<Solution> solutions = [new Day1(), new Day2(), new Day3()];

foreach (Solution solution in solutions)
{
    solution.Solve();
}