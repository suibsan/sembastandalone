
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserLogInResponse {
    [ProtoMember(1)]
    public Resources resources { get; set; }

    [ProtoMember(3)]
    public MasterData masterData { get; set; }

    [ProtoMember(2)]
    public int? moveToAreaLocatorId { get; set; }

}