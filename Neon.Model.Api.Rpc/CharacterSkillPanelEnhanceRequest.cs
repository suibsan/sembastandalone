
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CharacterSkillPanelEnhanceRequest {
    [ProtoMember(1)]
    public int characterSkillPanelId { get; set; }

    [ProtoMember(2)]
    public int level { get; set; }

}