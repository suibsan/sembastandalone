
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TutorialSkipResponse {
    [ProtoMember(1)]
    public int? moveToAreaLocatorId { get; set; }

    [ProtoMember(2)]
    public int[] deletedCharacterIds { get; set; }

    [ProtoMember(3)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(4)]
    public Resources changedResources { get; set; }

}