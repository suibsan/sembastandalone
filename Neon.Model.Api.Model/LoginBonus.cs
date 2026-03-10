
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class LoginBonus {
    [ProtoMember(1)]
    public int loginBonusId { get; set; }

    [ProtoMember(2)]
    public int receivedDay { get; set; }

    [ProtoMember(3)]
    public int loggedInDay { get; set; }

}