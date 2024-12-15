using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Pulumi.Options;

namespace ModularPipelines.Pulumi;

public class Pulumi : IPulumi
{
    private readonly ICommand _command;

    public Pulumi(ICommand command)
    {
        _command = command;
    }

    public async Task<CommandResult> Login(PulumiLoginOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Preview(PulumiPreviewOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Up(PulumiUpOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Stack(PulumiStackOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}