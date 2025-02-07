﻿using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Payments.PurchaseOrder.Models;

public record ConfigurationModel : BaseNopModel
{
    public int ActiveStoreScopeConfiguration { get; set; }

    [NopResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFee")]
    public decimal AdditionalFee { get; set; }

    public bool AdditionalFee_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFeePercentage")]
    public bool AdditionalFeePercentage { get; set; }

    public bool AdditionalFeePercentage_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Payment.PurchaseOrder.ShippableProductRequired")]
    public bool ShippableProductRequired { get; set; }

    public bool ShippableProductRequired_OverrideForStore { get; set; }
}