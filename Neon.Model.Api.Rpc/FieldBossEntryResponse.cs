
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FieldBossEntryResponse {
    [ProtoMember(1)]
    public Resources changedResources { get; set; }

    [ProtoMember(2)]
    public int? prevAccessFieldBossDifficultyId { get; set; }

}