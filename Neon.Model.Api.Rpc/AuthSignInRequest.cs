
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignInRequest {
    [ProtoMember(1)]
    public required string deviceSecret { get; set; }

    [ProtoMember(2)]
    public required string deviceUniqueId { get; set; }

    [ProtoMember(3)]
    public required string deviceToken { get; set; }

    [ProtoMember(4)]
    public required string deviceModel { get; set; }

    [ProtoMember(5)]
    public required string clientDigest { get; set; }

}