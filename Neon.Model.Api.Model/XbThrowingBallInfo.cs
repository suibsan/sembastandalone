
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbThrowingBallInfo {
    [ProtoMember(1)]
    public bool isThrown { get; set; }

    [ProtoMember(2)]
    public int positionFrom { get; set; }

    [ProtoMember(9)]
    public int baseNumFrom { get; set; }

    [ProtoMember(4)]
    public int baseNumOfReceive { get; set; }

    [ProtoMember(7)]
    public int? fielderMemberIdFrom { get; set; }

    [ProtoMember(8)]
    public int? fielderMemberIdTo { get; set; }

    [ProtoMember(5)]
    public float time { get; set; }

    [ProtoMember(3)]
    public int ballLevel { get; set; }

}