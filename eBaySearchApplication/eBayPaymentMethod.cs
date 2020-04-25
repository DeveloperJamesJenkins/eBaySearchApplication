using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    [Serializable()]
    public enum eBayPaymentMethod
    {
        /// <summary>
        /// American Express. Not applicable to US/CA eBay Motors listings
        /// </summary>
        AmEx,
        /// <summary>
        /// Cash-in-person option. Applicable only to US and Canada eBay Motors vehicles, (not the Parts and Accessories category).
        /// </summary>
       

        CashOnPickup,
        CCAccepted,
        COD,
        CODPrePayDelivery,
        CustomCode,
        Discover,
        ELV,
        Escrow,
        LoanCheck,
        MOCC,
        Moneybookers,
        MoneyXferAccepted,
        MoneyXferAcceptedInCheckout,
        None,
        Other,
        CashInPerson,
        OtherOnlinePayments,
        PaisaPayAccepted,
        PaisaPayEscrowEMI,
        PayMate,
        PaymentSeeDescription,
        CIPInCheckoutEnabled,
        ProPay,
        StandardPaymentMethod,
        VisaMC,

        /// <summary>
        /// PayPal payment method
        /// </summary>
        PayPal,
        /// <summary>
        /// PaisaPay payment method. The PaisaPay payment method is only for the India site (global ID EBAY-IN). 
        /// </summary>
        PaisaPay,
        /// <summary>
        /// PaisaPayEscrow EMI (Equal Monthly Installment) payment method. The PaisaPayEscrowEMI payment method is only for the India site (global ID EBAY-IN). 
        /// </summary>
        PaisaPayEMI,
        /// <summary>
        /// PersonalCheck
        /// </summary>
        PersonalCheck


    }
}
