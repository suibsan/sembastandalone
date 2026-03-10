
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBaseAdvanceInfo {
    [ProtoMember(1)]
    public required bool isPlayer { get; set; }

    [ProtoMember(2)]
    public required int memberId { get; set; }

    [ProtoMember(3)]
    public required int baseNum { get; set; }

    [ProtoMember(4)]
    public required int score { get; set; }

    [ProtoMember(5)]
    public required int prevScore { get; set; }

}