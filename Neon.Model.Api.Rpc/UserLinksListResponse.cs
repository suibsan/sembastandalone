
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserLinksListResponse {
    [ProtoMember(1)]
    public required bool apple { get; set; }

    [ProtoMember(2)]
    public required bool google { get; set; }

}