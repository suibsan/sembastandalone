
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DebugUserBulkResourceRequest {
    [ProtoMember(1)]
    public required int[] types_ { get; set; }

    [ProtoMember(2)]
    public required int stackableResourceRate { get; set; }

    [ProtoMember(4)]
    public required int entityCount { get; set; }

}