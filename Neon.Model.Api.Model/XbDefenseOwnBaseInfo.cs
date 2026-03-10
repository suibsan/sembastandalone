
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbDefenseOwnBaseInfo {
    [ProtoMember(1)]
    public bool isDefenseOwnBase { get; set; }

    [ProtoMember(4)]
    public int? fielderMemberId { get; set; }

    [ProtoMember(3)]
    public int baseNum { get; set; }

}