using ModularPipelines.Attributes;

namespace ModularPipelines.Pulumi.Options;

[CommandPrecedingArguments("up")]
public record PulumiUpOptions : PulumiOptions
{
    [CommandSwitch("--attach-debugger")]
    public bool? AttachDebugger { get; set; }

    [CommandSwitch("--config")]
    public string[]? Config { get; set; }

    [CommandSwitch("--config-file")]
    public string? ConfigFile { get; set; }

    [BooleanCommandSwitch("--continue-on-error")]
    public bool? ContinueOnError { get; set; }

    [BooleanCommandSwitch("--debug")]
    public bool? Debug { get; set; }

    [BooleanCommandSwitch("--diff")]
    public bool? Diff { get; set; }

    [BooleanCommandSwitch("--expect-no-changes")]
    public bool? ExpectNoChanges { get; set; }

    [CommandSwitch("--message")]
    public string? Message { get; set; }

    [CommandSwitch("--parallel")]
    public int? Parallel { get; set; }

    [CommandSwitch("--refresh")]
    public string? Refresh { get; set; }

    [BooleanCommandSwitch("--replace")]
    public string[]? Replace { get; set; }

    [CommandSwitch("--stack")]
    public string? Stack { get; set; }

    [BooleanCommandSwitch("--target")]
    public string[]? Target { get; set; }

    [BooleanCommandSwitch("--yes")]
    public bool? Yes { get; set; }

    [BooleanCommandSwitch("--skip-preview")]
    public bool? SkipPreview { get; set; }
}