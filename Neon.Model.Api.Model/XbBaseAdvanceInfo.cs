
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBaseAdvanceInfo {
    [ProtoMember(1)]
    public bool isPlayer { get; set; }

    [ProtoMember(2)]
    public int memberId { get; set; }

    [ProtoMember(3)]
    public int baseNum { get; set; }

    [ProtoMember(4)]
    public int score { get; set; }

    [ProtoMember(5)]
    public int prevScore { get; set; }

}