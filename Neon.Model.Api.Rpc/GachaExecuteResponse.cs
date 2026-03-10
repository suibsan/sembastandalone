
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaExecuteResponse {
    [ProtoMember(4)]
    public GachaCard[] drawnCards { get; set; }

    [ProtoMember(1)]
    public Reward[] drawnRewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

    [ProtoMember(3)]
    public Gacha gacha { get; set; }

    [ProtoMember(5)]
    public Rewards[] rewards { get; set; }

}