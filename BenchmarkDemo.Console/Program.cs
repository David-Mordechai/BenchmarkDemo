using BenchmarkDemo.Console;
using BenchmarkDemo.Library;
using BenchmarkDotNet.Running;

var isDebugMode = false;
#if DEBUG
    isDebugMode = true;
#endif

if (isDebugMode)
{
    var id = Guid.NewGuid();
    Console.WriteLine(id);

    var base64Id = Convert.ToBase64String(id.ToByteArray());
    Console.WriteLine(base64Id);

    var urlFriendlyBase64IdOptimize = Guider.ToStringFromGuidOptimize(id);
    Console.WriteLine(urlFriendlyBase64IdOptimize);

    var urlFriendlyBase64Id = Guider.ToStringFromGuid(id);
    Console.WriteLine(urlFriendlyBase64Id);

    var idAgain = Guider.ToGuidFromString(urlFriendlyBase64Id);
    Console.WriteLine(idAgain);

    var idAgainOptimize = Guider.ToGuidFromStringOptimize(urlFriendlyBase64Id);
    Console.WriteLine(idAgainOptimize);

    return;
}

BenchmarkRunner.Run<GuiderBenchmarks>();