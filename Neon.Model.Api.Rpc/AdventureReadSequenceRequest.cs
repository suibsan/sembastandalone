
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureReadSequenceRequest {
    [ProtoMember(1)]
    public int[] sequenceRequestIds { get; set; }

    [ProtoMember(2)]
    public NineSequenceRequest[] nineSequences { get; set; }

    [ProtoMember(4)]
    public int? miniGameId { get; set; }

    [ProtoMember(5)]
    public int areaType { get; set; }

    [ProtoMember(6)]
    public int areaKeyId { get; set; }

    [ProtoMember(3)]
    public CurrentLocation currentLocation { get; set; }

}