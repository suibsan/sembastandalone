
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AuthSignUpPasscodeResponse {
    [ProtoMember(2)]
    public string userName { get; set; }

    [ProtoMember(1)]
    public int language { get; set; }

    [ProtoMember(3)]
    public bool isDeleted { get; set; }

}