
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class KeyTask {
    [ProtoMember(1)]
    public int conditionId { get; set; }

    [ProtoMember(2)]
    public long count { get; set; }

    [ProtoMember(3)]
    public string name { get; set; }

}