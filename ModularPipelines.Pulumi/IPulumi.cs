using ModularPipelines.Models;
using ModularPipelines.Pulumi.Options;

namespace ModularPipelines.Pulumi;

public interface IPulumi
{
    public Task<CommandResult> Login(PulumiLoginOptions options, CancellationToken token = default);
    
    public Task<CommandResult> Preview(PulumiPreviewOptions options, CancellationToken token = default);
    
    public Task<CommandResult> Up(PulumiUpOptions options, CancellationToken token = default);
    
    public Task<CommandResult> Stack(PulumiStackOptions options, CancellationToken token = default);

}