using Algorithms.Benchmarks.Math;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MathBenchmarks>();
        }
    }
}
