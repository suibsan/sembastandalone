
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundDestinationBank {
    [ProtoMember(1)]
    public required int bankBranchId { get; set; }

    [ProtoMember(2)]
    public required int bankAccountType { get; set; }

    [ProtoMember(3)]
    public required int bankAccountNumber { get; set; }

    [ProtoMember(4)]
    public required string bankAccountHolder { get; set; }

}