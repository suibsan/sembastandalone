
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleSkipRequest {
    [ProtoMember(1)]
    public int battleEntryId { get; set; }

    [ProtoMember(2)]
    public BattleTrigger battleTrigger { get; set; }

    [ProtoMember(3)]
    public CurrentLocation currentLocation { get; set; }

    [ProtoMember(4)]
    public int[] lineCharacterIds { get; set; }

}