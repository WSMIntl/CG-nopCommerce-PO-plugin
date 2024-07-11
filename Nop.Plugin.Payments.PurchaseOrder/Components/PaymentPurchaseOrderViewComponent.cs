using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Payments.PurchaseOrder.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.PurchaseOrder.Components;

public class PaymentPurchaseOrderViewComponent : NopViewComponent
{
    public IViewComponentResult Invoke()
    {
        var model = new PaymentInfoModel();
        //set postback values (we cannot access "Form" with "GET" requests)
        if (Request.Method != WebRequestMethods.Http.Get)
        {
            model.PurchaseOrderNumber = HttpContext.Request.Form["PurchaseOrderNumber"];
        }

        //client asked for PO on billing step - if entered pre-fill on this plugin
        if (string.IsNullOrEmpty(model.PurchaseOrderNumber))
        {
            model.PurchaseOrderNumber = HttpContext.Session.GetString("OpcBillingPoNumber");
        }

        return View("~/Plugins/Payments.PurchaseOrder/Views/PaymentInfo.cshtml", model);
    }
}
