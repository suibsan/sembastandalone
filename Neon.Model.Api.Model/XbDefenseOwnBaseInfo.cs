
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbDefenseOwnBaseInfo {
    [ProtoMember(1)]
    public required bool isDefenseOwnBase { get; set; }

    [ProtoMember(4)]
    public required int? fielderMemberId { get; set; }

    [ProtoMember(3)]
    public required int baseNum { get; set; }

}