
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserCrossDateResponse {
    [ProtoMember(1)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}