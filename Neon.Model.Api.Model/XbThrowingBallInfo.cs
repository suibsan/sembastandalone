
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbThrowingBallInfo {
    [ProtoMember(1)]
    public required bool isThrown { get; set; }

    [ProtoMember(2)]
    public required int positionFrom { get; set; }

    [ProtoMember(9)]
    public required int baseNumFrom { get; set; }

    [ProtoMember(4)]
    public required int baseNumOfReceive { get; set; }

    [ProtoMember(7)]
    public required int? fielderMemberIdFrom { get; set; }

    [ProtoMember(8)]
    public required int? fielderMemberIdTo { get; set; }

    [ProtoMember(5)]
    public required float time { get; set; }

    [ProtoMember(3)]
    public required int ballLevel { get; set; }

}