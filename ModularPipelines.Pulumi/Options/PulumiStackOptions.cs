using ModularPipelines.Attributes;

namespace ModularPipelines.Pulumi.Options;

[CommandPrecedingArguments("stack")]
public record PulumiStackOptions : PulumiOptions
{
    [CommandSwitch("--stack")]
    public string? Stack { get; set; }

    [BooleanCommandSwitch("--show-secrets")]
    public bool? ShowSecrets { get; set; }

    [BooleanCommandSwitch("--show-ids")]
    public bool? ShowIds { get; set; }

    [BooleanCommandSwitch("--show-urns")]
    public bool? ShowUrns { get; set; }

    [BooleanCommandSwitch("--show-name")]
    public bool? ShowName { get; set; }
}