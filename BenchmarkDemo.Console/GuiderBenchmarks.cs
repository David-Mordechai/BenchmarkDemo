using BenchmarkDemo.Library;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo.Console;

[MemoryDiagnoser(displayGenColumns:false)]
public class GuiderBenchmarks
{
    private static readonly Guid TestIdAsGuid = Guid.Parse("acd9fd16-d24e-48c3-b0cc-fc63c545bb86");
    private const string TestIdAsString = "Fv3ZrE7Sw0iwzPxjxUW7hg";

    [Benchmark]
    public Guid ToGuidFromString()
    {
        return Guider.ToGuidFromString(TestIdAsString);
    }


    [Benchmark]
    public Guid ToGuidFromStringOptimize()
    {
        return Guider.ToGuidFromStringOptimize(TestIdAsString);
    }

    [Benchmark]
    public string ToStringFromGuid()
    {
        return Guider.ToStringFromGuid(TestIdAsGuid);
    }
    
    [Benchmark]
    public string ToStringFromGuidOptimize()
    {
        return Guider.ToStringFromGuidOptimize(TestIdAsGuid);
    }
}