
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class RefundApplicationController : Controller {

[Route("/refund_application/get")]
public IActionResult RefundApplication_Get() {
    // no request

    var res = RefundApplicationModel.RefundApplication_Get();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/refund_application/request_refund")]
public async Task<IActionResult> RefundApplication_RequestRefund() {
    var req = await RequestSerializer.Deserialize<RefundApplicationRequestRefundRequest>(Request);

    var res = RefundApplicationModel.RefundApplication_RequestRefund(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/refund_application/send_verification_code")]
public IActionResult RefundApplication_SendVerificationCode() {
    // no request

    var res = RefundApplicationModel.RefundApplication_SendVerificationCode();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/refund_application/update_email_id")]
public async Task<IActionResult> RefundApplication_UpdateEmailId() {
    var req = await RequestSerializer.Deserialize<RefundApplicationUpdateEmailIdRequest>(Request);

    var res = RefundApplicationModel.RefundApplication_UpdateEmailId(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/refund_application/verify_email_id")]
public async Task<IActionResult> RefundApplication_VerifyEmailId() {
    var req = await RequestSerializer.Deserialize<RefundApplicationVerifyEmailIdRequest>(Request);

    var res = RefundApplicationModel.RefundApplication_VerifyEmailId(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
