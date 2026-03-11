namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

using System.Text.Json; 

public class UserModel {
    public static UserCrossDateResponse? User_CrossDate() {
        return UserCrossDateResponse.Parser.ParseJson(SembaWrapper.Call("/user/cross_date", ""));
    }

    public static UserLogInResponse? User_LogIn() {
        return UserLogInResponse.Parser.ParseJson(SembaWrapper.Call("/user/log_in", ""));
    }

    public static ChangedResourcesResponse? User_Notification() {
        return ChangedResourcesResponse.Parser.ParseJson(SembaWrapper.Call("/user/notification", ""));
    }
}