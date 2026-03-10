
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignInResponse {
    [ProtoMember(1)]
    public string sessionToken { get; set; }

    [ProtoMember(2)]
    public bool deviceChanged { get; set; }

    [ProtoMember(4)]
    public int language { get; set; }

}