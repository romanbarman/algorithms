using System;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks.Math
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MathBenchmarks
    {
        private readonly UInt64 a;
        private readonly UInt64 b;

        public MathBenchmarks()
        {
            var aBytes = new byte[8];
            var bBytes = new byte[8];

            var random = new Random(55);
            random.NextBytes(aBytes);
            random.NextBytes(bBytes);

            a = BitConverter.ToUInt64(aBytes);
            b = BitConverter.ToUInt64(bBytes);
        }

        [Benchmark]
        public UInt64 Gcd() => Algorithms.Math.Math.Gcd(a, b);
    }
}