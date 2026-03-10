namespace Neon.Model.Api.Rpc;

using ProtoBuf;

[ProtoContract]
public class AuthSteamUserResponse {
    [ProtoMember(1)]
    public long UserId { get; set; }
}