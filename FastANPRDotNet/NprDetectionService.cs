using System.Text.Json;
using CSnakes.Runtime;

namespace FastANPRDotNet;

public interface INprDetectionService
{
    Task<List<NumberPlateDetectionResult>> DetectNumberPlatesAsync(IReadOnlyList<string> files, CancellationToken cancellationToken = default);
}

class NprDetectionService(IPythonEnvironment pythonEnvironment) : INprDetectionService
{
    public async Task<List<NumberPlateDetectionResult>> DetectNumberPlatesAsync(IReadOnlyList<string> files, CancellationToken cancellationToken = default)
    {
        using var lpr = pythonEnvironment.Lpr();
        return JsonSerializer.Deserialize<List<NumberPlateDetectionResult>>(await lpr.Run(files, cancellationToken)) ?? [];
    }
}
