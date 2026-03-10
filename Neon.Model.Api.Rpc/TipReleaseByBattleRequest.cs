
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TipReleaseByBattleRequest {
    [ProtoMember(1)]
    public BattleResult battleResult { get; set; }

}