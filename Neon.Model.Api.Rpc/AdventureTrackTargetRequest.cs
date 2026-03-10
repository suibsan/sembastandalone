
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureTrackTargetRequest {
    [ProtoMember(1)]
    public int? warpPointId { get; set; }

    [ProtoMember(2)]
    public int? fieldBossId { get; set; }

    [ProtoMember(3)]
    public int? dungeonId { get; set; }

}