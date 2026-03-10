
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpAppleResponse {
    [ProtoMember(1)]
    public long userId { get; set; }

    [ProtoMember(3)]
    public string userName { get; set; }

    [ProtoMember(2)]
    public int language { get; set; }

    [ProtoMember(4)]
    public bool isDeleted { get; set; }

}