using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;

namespace inline_null_check
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Lamda>();
        }

        
    }

    class HyperLink
    {
        public string Href { get; set; }


    }

    public class Lamda
    {
        [Benchmark]
        public void Something()
        {
            var callToActions = new List<HyperLink>();
            var defaultLink = callToActions.FirstOrDefault() != null ? callToActions.FirstOrDefault().Href : null;
        }
    } 
}
