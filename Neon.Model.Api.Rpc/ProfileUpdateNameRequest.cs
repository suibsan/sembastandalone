
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ProfileUpdateNameRequest {
    [ProtoMember(1)]
    public required string name { get; set; }

}