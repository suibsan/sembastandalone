
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbInningScore {
    [ProtoMember(1)]
    public required int inning { get; set; }

    [ProtoMember(2)]
    public required int score { get; set; }

}