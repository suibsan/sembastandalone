
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBuffInfo {
    [ProtoMember(1)]
    public required int index { get; set; }

    [ProtoMember(2)]
    public required int timing { get; set; }

    [ProtoMember(3)]
    public required int eventOrder { get; set; }

    [ProtoMember(4)]
    public required int[] playerBuffMemberIds { get; set; }

    [ProtoMember(5)]
    public required int[] enemyBuffMemberIds { get; set; }

}