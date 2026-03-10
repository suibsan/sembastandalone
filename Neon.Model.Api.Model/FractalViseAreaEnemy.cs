
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseAreaEnemy {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int fractalVisePieceId { get; set; }

    [ProtoMember(3)]
    public int index { get; set; }

    [ProtoMember(4)]
    public DateTime? defeatedAt { get; set; }

}