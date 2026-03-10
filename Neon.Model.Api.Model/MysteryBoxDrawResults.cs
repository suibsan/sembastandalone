
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MysteryBoxDrawResults {
    [ProtoMember(1)]
    public MysteryBoxDrawResult[] results { get; set; }

}