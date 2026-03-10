
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class HappyWorkerItem {
    [ProtoMember(1)]
    public required int happyWorkerItemId { get; set; }

    [ProtoMember(3)]
    public required bool isCleared { get; set; }

    [ProtoMember(4)]
    public required int? state { get; set; }

}