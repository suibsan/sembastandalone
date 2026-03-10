
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FieldBossEntryRequest {
    [ProtoMember(1)]
    public int fieldBossId { get; set; }

    [ProtoMember(2)]
    public CurrentLocation currentLocation { get; set; }

}