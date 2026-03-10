
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class KeyTask {
    [ProtoMember(1)]
    public required int conditionId { get; set; }

    [ProtoMember(2)]
    public required long count { get; set; }

    [ProtoMember(3)]
    public required string name { get; set; }

}