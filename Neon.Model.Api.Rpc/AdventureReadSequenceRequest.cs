
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureReadSequenceRequest {
    [ProtoMember(1)]
    public required int[] sequenceRequestIds { get; set; }

    [ProtoMember(2)]
    public required NineSequenceRequest[] nineSequences { get; set; }

    [ProtoMember(4)]
    public required int? miniGameId { get; set; }

    [ProtoMember(5)]
    public required int areaType { get; set; }

    [ProtoMember(6)]
    public required int areaKeyId { get; set; }

    [ProtoMember(3)]
    public required CurrentLocation currentLocation { get; set; }

}