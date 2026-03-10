
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbBlockadeZoneAreaInfo {
    [ProtoMember(1)]
    public required int[] prevBlockadedZoneAreaIndices { get; set; }

    [ProtoMember(2)]
    public required int[] blockadedZoneAreaIndices { get; set; }

    [ProtoMember(3)]
    public required int[] unblockadedZoneAreaIndices { get; set; }

}