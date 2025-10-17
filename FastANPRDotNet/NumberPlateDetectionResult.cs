using System;
using System.Text.Json.Serialization;

namespace FastANPRDotNet;

public class NumberPlate
{
    [JsonPropertyName("det_box")]
    public List<int> DetectionBox { get; set; } = [];

    [JsonPropertyName("det_conf")]
    public double DetectionConfidence { get; set; }

    [JsonPropertyName("rec_poly")]
    public List<List<int>> RecognizedPolygon { get; set; } = [];

    [JsonPropertyName("rec_text")]
    public string RecognizedText { get; set; } = string.Empty;

    [JsonPropertyName("rec_conf")]
    public double RecognitionConfidence { get; set; }
}

public class NumberPlateDetectionResult
{
    [JsonPropertyName("file")]
    public string File { get; set; } = string.Empty;

    [JsonPropertyName("number_plate")]
    public List<NumberPlate> NumberPlates { get; set; } = [];
}