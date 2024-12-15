using ModularPipelines.Attributes;

namespace ModularPipelines.Pulumi.Options;

[CommandPrecedingArguments("preview")]
public record PulumiPreviewOptions : PulumiOptions
{
    [BooleanCommandSwitch("--attach-debugger")]
    public bool? AttachDebugger { get; set; }

    [CommandSwitch("--config")]
    public string[]? Config { get; set; }

    [CommandSwitch("--config-file")]
    public string? ConfigFile { get; set; }

    [BooleanCommandSwitch("--debug")]
    public bool? Debug { get; set; }

    [BooleanCommandSwitch("--diff")]
    public bool? Diff { get; set; }

    [BooleanCommandSwitch("--expect-no-changes")]
    public bool? ExpectNoChanges { get; set; }

    [CommandSwitch("--json")]
    public bool? Json { get; set; }

    [CommandSwitch("--message")]
    public string? Message { get; set; }

    [CommandSwitch("--parallel")]
    public int? Parallel { get; set; }

    [CommandSwitch("--refresh")]
    public string? Refresh { get; set; }

    [CommandSwitch("--stack")]
    public string? Stack { get; set; }
}