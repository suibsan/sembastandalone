
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserDeleteResponse {
    [ProtoMember(1)]
    public required DateTime? willDeletedAt { get; set; }

}