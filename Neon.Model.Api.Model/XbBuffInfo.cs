
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBuffInfo {
    [ProtoMember(1)]
    public int index { get; set; }

    [ProtoMember(2)]
    public int timing { get; set; }

    [ProtoMember(3)]
    public int eventOrder { get; set; }

    [ProtoMember(4)]
    public int[] playerBuffMemberIds { get; set; }

    [ProtoMember(5)]
    public int[] enemyBuffMemberIds { get; set; }

}