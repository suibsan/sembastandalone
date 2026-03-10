
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TotalTask {
    [ProtoMember(1)]
    public int conditionId { get; set; }

    [ProtoMember(2)]
    public long count { get; set; }

}