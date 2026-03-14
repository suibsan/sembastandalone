
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class RefundApplicationModel {

public static RefundApplicationGetResponse? RefundApplication_Get() {
    // no request
    return RefundApplicationGetResponse.Parser.ParseJson(
        SembaWrapper.Call("/refund_application/get", "")
    );
}


public static RefundApplicationRequestRefundResponse? RefundApplication_RequestRefund(RefundApplicationRequestRefundRequest req) {
    Console.WriteLine($"RefundApplication_RequestRefund: {req}");
    return RefundApplicationRequestRefundResponse.Parser.ParseJson(
        SembaWrapper.Call("/refund_application/request_refund", req.ToString())
    );
}


public static RefundApplicationSendVerificationCodeResponse? RefundApplication_SendVerificationCode() {
    // no request
    return RefundApplicationSendVerificationCodeResponse.Parser.ParseJson(
        SembaWrapper.Call("/refund_application/send_verification_code", "")
    );
}


public static RefundApplicationUpdateEmailIdResponse? RefundApplication_UpdateEmailId(RefundApplicationUpdateEmailIdRequest req) {
    Console.WriteLine($"RefundApplication_UpdateEmailId: {req}");
    return RefundApplicationUpdateEmailIdResponse.Parser.ParseJson(
        SembaWrapper.Call("/refund_application/update_email_id", req.ToString())
    );
}


public static RefundApplicationVerifyEmailIdResponse? RefundApplication_VerifyEmailId(RefundApplicationVerifyEmailIdRequest req) {
    Console.WriteLine($"RefundApplication_VerifyEmailId: {req}");
    return RefundApplicationVerifyEmailIdResponse.Parser.ParseJson(
        SembaWrapper.Call("/refund_application/verify_email_id", req.ToString())
    );
}

}
