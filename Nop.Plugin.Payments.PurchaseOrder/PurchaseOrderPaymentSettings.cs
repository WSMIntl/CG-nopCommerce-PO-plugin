﻿using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.PurchaseOrder;

/// <summary>
/// Represents settings of "Purchase order" payment plugin
/// </summary>
public class PurchaseOrderPaymentSettings : ISettings
{
    /// <summary>
    /// Gets or sets an additional fee
    /// </summary>
    public decimal AdditionalFee { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
    /// </summary>
    public bool AdditionalFeePercentage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether shippable products are required in order to display this payment method during checkout
    /// </summary>
    public bool ShippableProductRequired { get; set; }
}
