
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbRunningInfo {
    [ProtoMember(1)]
    public int memberId { get; set; }

    [ProtoMember(2)]
    public float startPosition { get; set; }

    [ProtoMember(3)]
    public float endPosition { get; set; }

    [ProtoMember(4)]
    public float velocity { get; set; }

    [ProtoMember(5)]
    public float time { get; set; }

}