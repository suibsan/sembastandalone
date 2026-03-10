
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class HappyWorkerItem {
    [ProtoMember(1)]
    public int happyWorkerItemId { get; set; }

    [ProtoMember(3)]
    public bool isCleared { get; set; }

    [ProtoMember(4)]
    public int? state { get; set; }

}