
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPlayRequest {
    [ProtoMember(1)]
    public int xbId { get; set; }

    [ProtoMember(3)]
    public int zoneAreaIndex { get; set; }

    [ProtoMember(4)]
    public int commandId { get; set; }

    [ProtoMember(5)]
    public int? magicOrbId { get; set; }

    [ProtoMember(2)]
    public bool isAtBatSkip { get; set; }

}