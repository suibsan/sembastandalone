
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TutorialState {
    [ProtoMember(1)]
    public required int tutorialStatusKey { get; set; }

    [ProtoMember(2)]
    public required bool enabled { get; set; }

}