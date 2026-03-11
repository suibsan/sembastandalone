namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

using System.Text.Json; 

public class UserModel {
    public static UserLogInResponse? User_LogIn() {
        return UserLogInResponse.Parser.ParseJson(SembaWrapper.Call("/user/log_in", ""));
    }
}