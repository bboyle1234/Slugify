using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace Slugify.Core.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FooVsBar>();
        }
    }

    [MemoryDiagnoser, ShortRunJob]
    public class FooVsBar
    {
        private SlugHelper _helper;

        [Params("Short String", "Super @#$ Sdf fd#$3 String")]
        public string TestData;

        private string instance;

        [GlobalSetup]
        public void Setup()
        {
            instance = TestData;
            _helper = new SlugHelper();
        }
        //[Benchmark]
        //public string Test1()
        //{
        //    return _helper.GenerateSlug("here is some string");
        //}

        [Benchmark]
        public string Test2()
        {
            return _helper.GenerateSlug(instance);
        }

    }
}
