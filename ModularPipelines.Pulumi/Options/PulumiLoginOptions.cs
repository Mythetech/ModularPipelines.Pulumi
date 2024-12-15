using ModularPipelines.Attributes;

namespace ModularPipelines.Pulumi.Options;

[CommandPrecedingArguments("login")]
public record PulumiLoginOptions : PulumiOptions
{
    [CommandSwitch("--cloud-url")]
    public string? CloudUrl { get; set; }

    [CommandSwitch("--default-org")]
    public string? DefaultOrg { get; set; }

    [BooleanCommandSwitch("--insecure")]
    public bool? Insecure { get; set; }

    [BooleanCommandSwitch("--local")]
    public bool? Local { get; set; }

    [BooleanCommandSwitch("--interactive")]
    public bool? Interactive { get; set; }
}