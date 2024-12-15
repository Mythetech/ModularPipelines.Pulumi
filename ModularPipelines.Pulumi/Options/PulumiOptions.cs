using ModularPipelines.Attributes;
using ModularPipelines.Options;

namespace ModularPipelines.Pulumi.Options;

public record PulumiOptions() : CommandLineToolOptions("pulumi")
{
    [CommandSwitch("--color")]
    public string? Color { get; set; } // Choices: always, never, raw, auto

    [CommandSwitch("-C")]
    public string? Cwd { get; set; }

    [BooleanCommandSwitch("--disable-integrity-checking")]
    public bool? DisableIntegrityChecking { get; set; }

    [BooleanCommandSwitch("-e")]
    public bool? Emoji { get; set; }

    [BooleanCommandSwitch("-Q")]
    public bool? FullyQualifiedStackNames { get; set; }

    [BooleanCommandSwitch("--logflow")]
    public bool? LogFlow { get; set; }

    [BooleanCommandSwitch("--logtostderr")]
    public bool? LogToStderr { get; set; }

    [CommandSwitch("--memprofilerate")]
    public int? MemProfilerRate { get; set; }

    [BooleanCommandSwitch("--non-interactive")]
    public bool? NonInteractive { get; set; }

    [CommandSwitch("--profiling")]
    public string? Profiling { get; set; }

    [CommandSwitch("--tracing")]
    public string? Tracing { get; set; }

    [CommandSwitch("-v")]
    public int? Verbose { get; set; } 
}