namespace Neon.Model.Api.Rpc;

using ProtoBuf;

[ProtoContract]
public class AuthSteamUserRequest {
    [ProtoMember(1)]
    public required string SessionTicket { get; set; }
}