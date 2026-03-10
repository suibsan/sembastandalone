
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SynthesisRecipe {
    [ProtoMember(1)]
    public int synthesisRecipeId { get; set; }

}