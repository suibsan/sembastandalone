
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbRunningInfo {
    [ProtoMember(1)]
    public required int memberId { get; set; }

    [ProtoMember(2)]
    public required float startPosition { get; set; }

    [ProtoMember(3)]
    public required float endPosition { get; set; }

    [ProtoMember(4)]
    public required float velocity { get; set; }

    [ProtoMember(5)]
    public required float time { get; set; }

}