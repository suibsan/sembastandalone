
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpAppleRequest {
    [ProtoMember(1)]
    public string deviceSecret { get; set; }

    [ProtoMember(2)]
    public string deviceUniqueId { get; set; }

    [ProtoMember(3)]
    public string deviceModel { get; set; }

    [ProtoMember(4)]
    public string idToken { get; set; }

    [ProtoMember(5)]
    public bool execute { get; set; }

}