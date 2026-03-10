
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPlayRequest {
    [ProtoMember(1)]
    public required int xbId { get; set; }

    [ProtoMember(3)]
    public required int zoneAreaIndex { get; set; }

    [ProtoMember(4)]
    public required int commandId { get; set; }

    [ProtoMember(5)]
    public required int? magicOrbId { get; set; }

    [ProtoMember(2)]
    public required bool isAtBatSkip { get; set; }

}