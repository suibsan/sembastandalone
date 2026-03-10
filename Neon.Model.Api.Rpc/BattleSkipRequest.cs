
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleSkipRequest {
    [ProtoMember(1)]
    public required int battleEntryId { get; set; }

    [ProtoMember(2)]
    public required BattleTrigger battleTrigger { get; set; }

    [ProtoMember(3)]
    public required CurrentLocation currentLocation { get; set; }

    [ProtoMember(4)]
    public required int[] lineCharacterIds { get; set; }

}