using Intellenum;

namespace Soenneker.Stripe.Enums.EventTypes;

/// <summary>
/// Stripe event types as strongly-typed <see cref="Intellenum"/> values.
/// </summary>
[Intellenum<string>]
public sealed partial class StripeEventType
{
    /// <summary>
    /// account.application.authorized
    /// </summary>
    public static readonly StripeEventType AccountApplicationAuthorized = new("account.application.authorized");

    /// <summary>
    /// account.application.deauthorized
    /// </summary>
    public static readonly StripeEventType AccountApplicationDeauthorized = new("account.application.deauthorized");

    /// <summary>
    /// account.external_account.created
    /// </summary>
    public static readonly StripeEventType AccountExternalAccountCreated = new("account.external_account.created");

    /// <summary>
    /// account.external_account.deleted
    /// </summary>
    public static readonly StripeEventType AccountExternalAccountDeleted = new("account.external_account.deleted");

    /// <summary>
    /// account.external_account.updated
    /// </summary>
    public static readonly StripeEventType AccountExternalAccountUpdated = new("account.external_account.updated");

    /// <summary>
    /// account.updated
    /// </summary>
    public static readonly StripeEventType AccountUpdated = new("account.updated");

    /// <summary>
    /// application_fee.created
    /// </summary>
    public static readonly StripeEventType ApplicationFeeCreated = new("application_fee.created");

    /// <summary>
    /// application_fee.refund.updated
    /// </summary>
    public static readonly StripeEventType ApplicationFeeRefundUpdated = new("application_fee.refund.updated");

    /// <summary>
    /// application_fee.refunded
    /// </summary>
    public static readonly StripeEventType ApplicationFeeRefunded = new("application_fee.refunded");

    /// <summary>
    /// balance.available
    /// </summary>
    public static readonly StripeEventType BalanceAvailable = new("balance.available");

    /// <summary>
    /// billing.alert.triggered
    /// </summary>
    public static readonly StripeEventType BillingAlertTriggered = new("billing.alert.triggered");

    /// <summary>
    /// billing_portal.configuration.created
    /// </summary>
    public static readonly StripeEventType BillingPortalConfigurationCreated = new("billing_portal.configuration.created");

    /// <summary>
    /// billing_portal.configuration.updated
    /// </summary>
    public static readonly StripeEventType BillingPortalConfigurationUpdated = new("billing_portal.configuration.updated");

    /// <summary>
    /// billing_portal.session.created
    /// </summary>
    public static readonly StripeEventType BillingPortalSessionCreated = new("billing_portal.session.created");

    /// <summary>
    /// capability.updated
    /// </summary>
    public static readonly StripeEventType CapabilityUpdated = new("capability.updated");

    /// <summary>
    /// cash_balance.funds_available
    /// </summary>
    public static readonly StripeEventType CashBalanceFundsAvailable = new("cash_balance.funds_available");

    /// <summary>
    /// charge.captured
    /// </summary>
    public static readonly StripeEventType ChargeCaptured = new("charge.captured");

    /// <summary>
    /// charge.dispute.closed
    /// </summary>
    public static readonly StripeEventType ChargeDisputeClosed = new("charge.dispute.closed");

    /// <summary>
    /// charge.dispute.created
    /// </summary>
    public static readonly StripeEventType ChargeDisputeCreated = new("charge.dispute.created");

    /// <summary>
    /// charge.dispute.funds_reinstated
    /// </summary>
    public static readonly StripeEventType ChargeDisputeFundsReinstated = new("charge.dispute.funds_reinstated");

    /// <summary>
    /// charge.dispute.funds_withdrawn
    /// </summary>
    public static readonly StripeEventType ChargeDisputeFundsWithdrawn = new("charge.dispute.funds_withdrawn");

    /// <summary>
    /// charge.dispute.updated
    /// </summary>
    public static readonly StripeEventType ChargeDisputeUpdated = new("charge.dispute.updated");

    /// <summary>
    /// charge.expired
    /// </summary>
    public static readonly StripeEventType ChargeExpired = new("charge.expired");

    /// <summary>
    /// charge.failed
    /// </summary>
    public static readonly StripeEventType ChargeFailed = new("charge.failed");

    /// <summary>
    /// charge.pending
    /// </summary>
    public static readonly StripeEventType ChargePending = new("charge.pending");

    /// <summary>
    /// charge.refund.updated
    /// </summary>
    public static readonly StripeEventType ChargeRefundUpdated = new("charge.refund.updated");

    /// <summary>
    /// charge.refunded
    /// </summary>
    public static readonly StripeEventType ChargeRefunded = new("charge.refunded");

    /// <summary>
    /// charge.succeeded
    /// </summary>
    public static readonly StripeEventType ChargeSucceeded = new("charge.succeeded");

    /// <summary>
    /// charge.updated
    /// </summary>
    public static readonly StripeEventType ChargeUpdated = new("charge.updated");

    /// <summary>
    /// checkout.session.async_payment_failed
    /// </summary>
    public static readonly StripeEventType CheckoutSessionAsyncPaymentFailed = new("checkout.session.async_payment_failed");

    /// <summary>
    /// checkout.session.async_payment_succeeded
    /// </summary>
    public static readonly StripeEventType CheckoutSessionAsyncPaymentSucceeded = new("checkout.session.async_payment_succeeded");

    /// <summary>
    /// checkout.session.completed
    /// </summary>
    public static readonly StripeEventType CheckoutSessionCompleted = new("checkout.session.completed");

    /// <summary>
    /// checkout.session.expired
    /// </summary>
    public static readonly StripeEventType CheckoutSessionExpired = new("checkout.session.expired");

    /// <summary>
    /// climate.order.canceled
    /// </summary>
    public static readonly StripeEventType ClimateOrderCanceled = new("climate.order.canceled");

    /// <summary>
    /// climate.order.created
    /// </summary>
    public static readonly StripeEventType ClimateOrderCreated = new("climate.order.created");

    /// <summary>
    /// climate.order.delayed
    /// </summary>
    public static readonly StripeEventType ClimateOrderDelayed = new("climate.order.delayed");

    /// <summary>
    /// climate.order.delivered
    /// </summary>
    public static readonly StripeEventType ClimateOrderDelivered = new("climate.order.delivered");

    /// <summary>
    /// climate.order.product_substituted
    /// </summary>
    public static readonly StripeEventType ClimateOrderProductSubstituted = new("climate.order.product_substituted");

    /// <summary>
    /// climate.product.created
    /// </summary>
    public static readonly StripeEventType ClimateProductCreated = new("climate.product.created");

    /// <summary>
    /// climate.product.pricing_updated
    /// </summary>
    public static readonly StripeEventType ClimateProductPricingUpdated = new("climate.product.pricing_updated");

    /// <summary>
    /// coupon.created
    /// </summary>
    public static readonly StripeEventType CouponCreated = new("coupon.created");

    /// <summary>
    /// coupon.deleted
    /// </summary>
    public static readonly StripeEventType CouponDeleted = new("coupon.deleted");

    /// <summary>
    /// coupon.updated
    /// </summary>
    public static readonly StripeEventType CouponUpdated = new("coupon.updated");

    /// <summary>
    /// credit_note.created
    /// </summary>
    public static readonly StripeEventType CreditNoteCreated = new("credit_note.created");

    /// <summary>
    /// credit_note.updated
    /// </summary>
    public static readonly StripeEventType CreditNoteUpdated = new("credit_note.updated");

    /// <summary>
    /// credit_note.voided
    /// </summary>
    public static readonly StripeEventType CreditNoteVoided = new("credit_note.voided");

    /// <summary>
    /// customer.created
    /// </summary>
    public static readonly StripeEventType CustomerCreated = new("customer.created");

    /// <summary>
    /// customer.deleted
    /// </summary>
    public static readonly StripeEventType CustomerDeleted = new("customer.deleted");

    /// <summary>
    /// customer.discount.created
    /// </summary>
    public static readonly StripeEventType CustomerDiscountCreated = new("customer.discount.created");

    /// <summary>
    /// customer.discount.deleted
    /// </summary>
    public static readonly StripeEventType CustomerDiscountDeleted = new("customer.discount.deleted");

    /// <summary>
    /// customer.discount.updated
    /// </summary>
    public static readonly StripeEventType CustomerDiscountUpdated = new("customer.discount.updated");

    /// <summary>
    /// customer.source.created
    /// </summary>
    public static readonly StripeEventType CustomerSourceCreated = new("customer.source.created");

    /// <summary>
    /// customer.source.deleted
    /// </summary>
    public static readonly StripeEventType CustomerSourceDeleted = new("customer.source.deleted");

    /// <summary>
    /// customer.source.expiring
    /// </summary>
    public static readonly StripeEventType CustomerSourceExpiring = new("customer.source.expiring");

    /// <summary>
    /// customer.source.updated
    /// </summary>
    public static readonly StripeEventType CustomerSourceUpdated = new("customer.source.updated");

    /// <summary>
    /// customer.subscription.created
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionCreated = new("customer.subscription.created");

    /// <summary>
    /// customer.subscription.deleted
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionDeleted = new("customer.subscription.deleted");

    /// <summary>
    /// customer.subscription.paused
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionPaused = new("customer.subscription.paused");

    /// <summary>
    /// customer.subscription.pending_update_applied
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionPendingUpdateApplied = new("customer.subscription.pending_update_applied");

    /// <summary>
    /// customer.subscription.pending_update_expired
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionPendingUpdateExpired = new("customer.subscription.pending_update_expired");

    /// <summary>
    /// customer.subscription.resumed
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionResumed = new("customer.subscription.resumed");

    /// <summary>
    /// customer.subscription.trial_will_end
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionTrialWillEnd = new("customer.subscription.trial_will_end");

    /// <summary>
    /// customer.subscription.updated
    /// </summary>
    public static readonly StripeEventType CustomerSubscriptionUpdated = new("customer.subscription.updated");

    /// <summary>
    /// customer.tax_id.created
    /// </summary>
    public static readonly StripeEventType CustomerTaxIdCreated = new("customer.tax_id.created");

    /// <summary>
    /// customer.tax_id.deleted
    /// </summary>
    public static readonly StripeEventType CustomerTaxIdDeleted = new("customer.tax_id.deleted");

    /// <summary>
    /// customer.tax_id.updated
    /// </summary>
    public static readonly StripeEventType CustomerTaxIdUpdated = new("customer.tax_id.updated");

    /// <summary>
    /// customer.updated
    /// </summary>
    public static readonly StripeEventType CustomerUpdated = new("customer.updated");

    /// <summary>
    /// customer_cash_balance_transaction.created
    /// </summary>
    public static readonly StripeEventType CustomerCashBalanceTransactionCreated = new("customer_cash_balance_transaction.created");

    /// <summary>
    /// entitlements.active_entitlement_summary.updated
    /// </summary>
    public static readonly StripeEventType EntitlementsActiveEntitlementSummaryUpdated = new("entitlements.active_entitlement_summary.updated");

    /// <summary>
    /// file.created
    /// </summary>
    public static readonly StripeEventType FileCreated = new("file.created");

    /// <summary>
    /// financial_connections.account.created
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountCreated = new("financial_connections.account.created");

    /// <summary>
    /// financial_connections.account.deactivated
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountDeactivated = new("financial_connections.account.deactivated");

    /// <summary>
    /// financial_connections.account.disconnected
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountDisconnected = new("financial_connections.account.disconnected");

    /// <summary>
    /// financial_connections.account.reactivated
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountReactivated = new("financial_connections.account.reactivated");

    /// <summary>
    /// financial_connections.account.refreshed_balance
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountRefreshedBalance = new("financial_connections.account.refreshed_balance");

    /// <summary>
    /// financial_connections.account.refreshed_ownership
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountRefreshedOwnership = new("financial_connections.account.refreshed_ownership");

    /// <summary>
    /// financial_connections.account.refreshed_transactions
    /// </summary>
    public static readonly StripeEventType FinancialConnectionsAccountRefreshedTransactions = new("financial_connections.account.refreshed_transactions");

    /// <summary>
    /// identity.verification_session.canceled
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionCanceled = new("identity.verification_session.canceled");

    /// <summary>
    /// identity.verification_session.created
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionCreated = new("identity.verification_session.created");

    /// <summary>
    /// identity.verification_session.processing
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionProcessing = new("identity.verification_session.processing");

    /// <summary>
    /// identity.verification_session.redacted
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionRedacted = new("identity.verification_session.redacted");

    /// <summary>
    /// identity.verification_session.requires_input
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionRequiresInput = new("identity.verification_session.requires_input");

    /// <summary>
    /// identity.verification_session.verified
    /// </summary>
    public static readonly StripeEventType IdentityVerificationSessionVerified = new("identity.verification_session.verified");

    /// <summary>
    /// invoice.created
    /// </summary>
    public static readonly StripeEventType InvoiceCreated = new("invoice.created");

    /// <summary>
    /// invoice.deleted
    /// </summary>
    public static readonly StripeEventType InvoiceDeleted = new("invoice.deleted");

    /// <summary>
    /// invoice.finalization_failed
    /// </summary>
    public static readonly StripeEventType InvoiceFinalizationFailed = new("invoice.finalization_failed");

    /// <summary>
    /// invoice.finalized
    /// </summary>
    public static readonly StripeEventType InvoiceFinalized = new("invoice.finalized");

    /// <summary>
    /// invoice.marked_uncollectible
    /// </summary>
    public static readonly StripeEventType InvoiceMarkedUncollectible = new("invoice.marked_uncollectible");

    /// <summary>
    /// invoice.overdue
    /// </summary>
    public static readonly StripeEventType InvoiceOverdue = new("invoice.overdue");

    /// <summary>
    /// invoice.overpaid
    /// </summary>
    public static readonly StripeEventType InvoiceOverpaid = new("invoice.overpaid");

    /// <summary>
    /// invoice.paid
    /// </summary>
    public static readonly StripeEventType InvoicePaid = new("invoice.paid");

    /// <summary>
    /// invoice.payment_action_required
    /// </summary>
    public static readonly StripeEventType InvoicePaymentActionRequired = new("invoice.payment_action_required");

    /// <summary>
    /// invoice.payment_failed
    /// </summary>
    public static readonly StripeEventType InvoicePaymentFailed = new("invoice.payment_failed");

    /// <summary>
    /// invoice.payment_succeeded
    /// </summary>
    public static readonly StripeEventType InvoicePaymentSucceeded = new("invoice.payment_succeeded");

    /// <summary>
    /// invoice.sent
    /// </summary>
    public static readonly StripeEventType InvoiceSent = new("invoice.sent");

    /// <summary>
    /// invoice.upcoming
    /// </summary>
    public static readonly StripeEventType InvoiceUpcoming = new("invoice.upcoming");

    /// <summary>
    /// invoice.updated
    /// </summary>
    public static readonly StripeEventType InvoiceUpdated = new("invoice.updated");

    /// <summary>
    /// invoice.voided
    /// </summary>
    public static readonly StripeEventType InvoiceVoided = new("invoice.voided");

    /// <summary>
    /// invoice.will_be_due
    /// </summary>
    public static readonly StripeEventType InvoiceWillBeDue = new("invoice.will_be_due");

    /// <summary>
    /// invoice_payment.paid
    /// </summary>
    public static readonly StripeEventType InvoicePaymentPaid = new("invoice_payment.paid");

    /// <summary>
    /// invoiceitem.created
    /// </summary>
    public static readonly StripeEventType InvoiceitemCreated = new("invoiceitem.created");

    /// <summary>
    /// invoiceitem.deleted
    /// </summary>
    public static readonly StripeEventType InvoiceitemDeleted = new("invoiceitem.deleted");

    /// <summary>
    /// issuing_authorization.created
    /// </summary>
    public static readonly StripeEventType IssuingAuthorizationCreated = new("issuing_authorization.created");

    /// <summary>
    /// issuing_authorization.request
    /// </summary>
    public static readonly StripeEventType IssuingAuthorizationRequest = new("issuing_authorization.request");

    /// <summary>
    /// issuing_authorization.updated
    /// </summary>
    public static readonly StripeEventType IssuingAuthorizationUpdated = new("issuing_authorization.updated");

    /// <summary>
    /// issuing_card.created
    /// </summary>
    public static readonly StripeEventType IssuingCardCreated = new("issuing_card.created");

    /// <summary>
    /// issuing_card.updated
    /// </summary>
    public static readonly StripeEventType IssuingCardUpdated = new("issuing_card.updated");

    /// <summary>
    /// issuing_cardholder.created
    /// </summary>
    public static readonly StripeEventType IssuingCardholderCreated = new("issuing_cardholder.created");

    /// <summary>
    /// issuing_cardholder.updated
    /// </summary>
    public static readonly StripeEventType IssuingCardholderUpdated = new("issuing_cardholder.updated");

    /// <summary>
    /// issuing_dispute.closed
    /// </summary>
    public static readonly StripeEventType IssuingDisputeClosed = new("issuing_dispute.closed");

    /// <summary>
    /// issuing_dispute.created
    /// </summary>
    public static readonly StripeEventType IssuingDisputeCreated = new("issuing_dispute.created");

    /// <summary>
    /// issuing_dispute.funds_reinstated
    /// </summary>
    public static readonly StripeEventType IssuingDisputeFundsReinstated = new("issuing_dispute.funds_reinstated");

    /// <summary>
    /// issuing_dispute.funds_rescinded
    /// </summary>
    public static readonly StripeEventType IssuingDisputeFundsRescinded = new("issuing_dispute.funds_rescinded");

    /// <summary>
    /// issuing_dispute.submitted
    /// </summary>
    public static readonly StripeEventType IssuingDisputeSubmitted = new("issuing_dispute.submitted");

    /// <summary>
    /// issuing_dispute.updated
    /// </summary>
    public static readonly StripeEventType IssuingDisputeUpdated = new("issuing_dispute.updated");

    /// <summary>
    /// issuing_personalization_design.activated
    /// </summary>
    public static readonly StripeEventType IssuingPersonalizationDesignActivated = new("issuing_personalization_design.activated");

    /// <summary>
    /// issuing_personalization_design.deactivated
    /// </summary>
    public static readonly StripeEventType IssuingPersonalizationDesignDeactivated = new("issuing_personalization_design.deactivated");

    /// <summary>
    /// issuing_personalization_design.rejected
    /// </summary>
    public static readonly StripeEventType IssuingPersonalizationDesignRejected = new("issuing_personalization_design.rejected");

    /// <summary>
    /// issuing_personalization_design.updated
    /// </summary>
    public static readonly StripeEventType IssuingPersonalizationDesignUpdated = new("issuing_personalization_design.updated");

    /// <summary>
    /// issuing_token.created
    /// </summary>
    public static readonly StripeEventType IssuingTokenCreated = new("issuing_token.created");

    /// <summary>
    /// issuing_token.updated
    /// </summary>
    public static readonly StripeEventType IssuingTokenUpdated = new("issuing_token.updated");

    /// <summary>
    /// issuing_transaction.created
    /// </summary>
    public static readonly StripeEventType IssuingTransactionCreated = new("issuing_transaction.created");

    /// <summary>
    /// issuing_transaction.purchase_details_receipt_updated
    /// </summary>
    public static readonly StripeEventType IssuingTransactionPurchaseDetailsReceiptUpdated = new("issuing_transaction.purchase_details_receipt_updated");

    /// <summary>
    /// issuing_transaction.updated
    /// </summary>
    public static readonly StripeEventType IssuingTransactionUpdated = new("issuing_transaction.updated");

    /// <summary>
    /// mandate.updated
    /// </summary>
    public static readonly StripeEventType MandateUpdated = new("mandate.updated");

    /// <summary>
    /// payment_intent.amount_capturable_updated
    /// </summary>
    public static readonly StripeEventType PaymentIntentAmountCapturableUpdated = new("payment_intent.amount_capturable_updated");

    /// <summary>
    /// payment_intent.canceled
    /// </summary>
    public static readonly StripeEventType PaymentIntentCanceled = new("payment_intent.canceled");

    /// <summary>
    /// payment_intent.created
    /// </summary>
    public static readonly StripeEventType PaymentIntentCreated = new("payment_intent.created");

    /// <summary>
    /// payment_intent.partially_funded
    /// </summary>
    public static readonly StripeEventType PaymentIntentPartiallyFunded = new("payment_intent.partially_funded");

    /// <summary>
    /// payment_intent.payment_failed
    /// </summary>
    public static readonly StripeEventType PaymentIntentPaymentFailed = new("payment_intent.payment_failed");

    /// <summary>
    /// payment_intent.processing
    /// </summary>
    public static readonly StripeEventType PaymentIntentProcessing = new("payment_intent.processing");

    /// <summary>
    /// payment_intent.requires_action
    /// </summary>
    public static readonly StripeEventType PaymentIntentRequiresAction = new("payment_intent.requires_action");

    /// <summary>
    /// payment_intent.succeeded
    /// </summary>
    public static readonly StripeEventType PaymentIntentSucceeded = new("payment_intent.succeeded");

    /// <summary>
    /// payment_link.created
    /// </summary>
    public static readonly StripeEventType PaymentLinkCreated = new("payment_link.created");

    /// <summary>
    /// payment_link.updated
    /// </summary>
    public static readonly StripeEventType PaymentLinkUpdated = new("payment_link.updated");

    /// <summary>
    /// payment_method.attached
    /// </summary>
    public static readonly StripeEventType PaymentMethodAttached = new("payment_method.attached");

    /// <summary>
    /// payment_method.automatically_updated
    /// </summary>
    public static readonly StripeEventType PaymentMethodAutomaticallyUpdated = new("payment_method.automatically_updated");

    /// <summary>
    /// payment_method.detached
    /// </summary>
    public static readonly StripeEventType PaymentMethodDetached = new("payment_method.detached");

    /// <summary>
    /// payment_method.updated
    /// </summary>
    public static readonly StripeEventType PaymentMethodUpdated = new("payment_method.updated");

    /// <summary>
    /// payout.canceled
    /// </summary>
    public static readonly StripeEventType PayoutCanceled = new("payout.canceled");

    /// <summary>
    /// payout.created
    /// </summary>
    public static readonly StripeEventType PayoutCreated = new("payout.created");

    /// <summary>
    /// payout.failed
    /// </summary>
    public static readonly StripeEventType PayoutFailed = new("payout.failed");

    /// <summary>
    /// payout.paid
    /// </summary>
    public static readonly StripeEventType PayoutPaid = new("payout.paid");

    /// <summary>
    /// payout.reconciliation_completed
    /// </summary>
    public static readonly StripeEventType PayoutReconciliationCompleted = new("payout.reconciliation_completed");

    /// <summary>
    /// payout.updated
    /// </summary>
    public static readonly StripeEventType PayoutUpdated = new("payout.updated");

    /// <summary>
    /// person.created
    /// </summary>
    public static readonly StripeEventType PersonCreated = new("person.created");

    /// <summary>
    /// person.deleted
    /// </summary>
    public static readonly StripeEventType PersonDeleted = new("person.deleted");

    /// <summary>
    /// person.updated
    /// </summary>
    public static readonly StripeEventType PersonUpdated = new("person.updated");

    /// <summary>
    /// plan.created
    /// </summary>
    public static readonly StripeEventType PlanCreated = new("plan.created");

    /// <summary>
    /// plan.deleted
    /// </summary>
    public static readonly StripeEventType PlanDeleted = new("plan.deleted");

    /// <summary>
    /// plan.updated
    /// </summary>
    public static readonly StripeEventType PlanUpdated = new("plan.updated");

    /// <summary>
    /// price.created
    /// </summary>
    public static readonly StripeEventType PriceCreated = new("price.created");

    /// <summary>
    /// price.deleted
    /// </summary>
    public static readonly StripeEventType PriceDeleted = new("price.deleted");

    /// <summary>
    /// price.updated
    /// </summary>
    public static readonly StripeEventType PriceUpdated = new("price.updated");

    /// <summary>
    /// product.created
    /// </summary>
    public static readonly StripeEventType ProductCreated = new("product.created");

    /// <summary>
    /// product.deleted
    /// </summary>
    public static readonly StripeEventType ProductDeleted = new("product.deleted");

    /// <summary>
    /// product.updated
    /// </summary>
    public static readonly StripeEventType ProductUpdated = new("product.updated");

    /// <summary>
    /// promotion_code.created
    /// </summary>
    public static readonly StripeEventType PromotionCodeCreated = new("promotion_code.created");

    /// <summary>
    /// promotion_code.updated
    /// </summary>
    public static readonly StripeEventType PromotionCodeUpdated = new("promotion_code.updated");

    /// <summary>
    /// quote.accepted
    /// </summary>
    public static readonly StripeEventType QuoteAccepted = new("quote.accepted");

    /// <summary>
    /// quote.canceled
    /// </summary>
    public static readonly StripeEventType QuoteCanceled = new("quote.canceled");

    /// <summary>
    /// quote.created
    /// </summary>
    public static readonly StripeEventType QuoteCreated = new("quote.created");

    /// <summary>
    /// quote.finalized
    /// </summary>
    public static readonly StripeEventType QuoteFinalized = new("quote.finalized");

    /// <summary>
    /// radar.early_fraud_warning.created
    /// </summary>
    public static readonly StripeEventType RadarEarlyFraudWarningCreated = new("radar.early_fraud_warning.created");

    /// <summary>
    /// radar.early_fraud_warning.updated
    /// </summary>
    public static readonly StripeEventType RadarEarlyFraudWarningUpdated = new("radar.early_fraud_warning.updated");

    /// <summary>
    /// refund.created
    /// </summary>
    public static readonly StripeEventType RefundCreated = new("refund.created");

    /// <summary>
    /// refund.failed
    /// </summary>
    public static readonly StripeEventType RefundFailed = new("refund.failed");

    /// <summary>
    /// refund.updated
    /// </summary>
    public static readonly StripeEventType RefundUpdated = new("refund.updated");

    /// <summary>
    /// reporting.report_run.failed
    /// </summary>
    public static readonly StripeEventType ReportingReportRunFailed = new("reporting.report_run.failed");

    /// <summary>
    /// reporting.report_run.succeeded
    /// </summary>
    public static readonly StripeEventType ReportingReportRunSucceeded = new("reporting.report_run.succeeded");

    /// <summary>
    /// reporting.report_type.updated
    /// </summary>
    public static readonly StripeEventType ReportingReportTypeUpdated = new("reporting.report_type.updated");

    /// <summary>
    /// review.closed
    /// </summary>
    public static readonly StripeEventType ReviewClosed = new("review.closed");

    /// <summary>
    /// review.opened
    /// </summary>
    public static readonly StripeEventType ReviewOpened = new("review.opened");

    /// <summary>
    /// setup_intent.canceled
    /// </summary>
    public static readonly StripeEventType SetupIntentCanceled = new("setup_intent.canceled");

    /// <summary>
    /// setup_intent.created
    /// </summary>
    public static readonly StripeEventType SetupIntentCreated = new("setup_intent.created");

    /// <summary>
    /// setup_intent.requires_action
    /// </summary>
    public static readonly StripeEventType SetupIntentRequiresAction = new("setup_intent.requires_action");

    /// <summary>
    /// setup_intent.setup_failed
    /// </summary>
    public static readonly StripeEventType SetupIntentSetupFailed = new("setup_intent.setup_failed");

    /// <summary>
    /// setup_intent.succeeded
    /// </summary>
    public static readonly StripeEventType SetupIntentSucceeded = new("setup_intent.succeeded");

    /// <summary>
    /// sigma.scheduled_query_run.created
    /// </summary>
    public static readonly StripeEventType SigmaScheduledQueryRunCreated = new("sigma.scheduled_query_run.created");

    /// <summary>
    /// source.canceled
    /// </summary>
    public static readonly StripeEventType SourceCanceled = new("source.canceled");

    /// <summary>
    /// source.chargeable
    /// </summary>
    public static readonly StripeEventType SourceChargeable = new("source.chargeable");

    /// <summary>
    /// source.failed
    /// </summary>
    public static readonly StripeEventType SourceFailed = new("source.failed");

    /// <summary>
    /// source.mandate_notification
    /// </summary>
    public static readonly StripeEventType SourceMandateNotification = new("source.mandate_notification");

    /// <summary>
    /// source.refund_attributes_required
    /// </summary>
    public static readonly StripeEventType SourceRefundAttributesRequired = new("source.refund_attributes_required");

    /// <summary>
    /// source.transaction.created
    /// </summary>
    public static readonly StripeEventType SourceTransactionCreated = new("source.transaction.created");

    /// <summary>
    /// source.transaction.updated
    /// </summary>
    public static readonly StripeEventType SourceTransactionUpdated = new("source.transaction.updated");

    /// <summary>
    /// subscription_schedule.aborted
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleAborted = new("subscription_schedule.aborted");

    /// <summary>
    /// subscription_schedule.canceled
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleCanceled = new("subscription_schedule.canceled");

    /// <summary>
    /// subscription_schedule.completed
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleCompleted = new("subscription_schedule.completed");

    /// <summary>
    /// subscription_schedule.created
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleCreated = new("subscription_schedule.created");

    /// <summary>
    /// subscription_schedule.expiring
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleExpiring = new("subscription_schedule.expiring");

    /// <summary>
    /// subscription_schedule.released
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleReleased = new("subscription_schedule.released");

    /// <summary>
    /// subscription_schedule.updated
    /// </summary>
    public static readonly StripeEventType SubscriptionScheduleUpdated = new("subscription_schedule.updated");

    /// <summary>
    /// tax.settings.updated
    /// </summary>
    public static readonly StripeEventType TaxSettingsUpdated = new("tax.settings.updated");

    /// <summary>
    /// tax_rate.created
    /// </summary>
    public static readonly StripeEventType TaxRateCreated = new("tax_rate.created");

    /// <summary>
    /// tax_rate.updated
    /// </summary>
    public static readonly StripeEventType TaxRateUpdated = new("tax_rate.updated");

    /// <summary>
    /// terminal.reader.action_failed
    /// </summary>
    public static readonly StripeEventType TerminalReaderActionFailed = new("terminal.reader.action_failed");

    /// <summary>
    /// terminal.reader.action_succeeded
    /// </summary>
    public static readonly StripeEventType TerminalReaderActionSucceeded = new("terminal.reader.action_succeeded");

    /// <summary>
    /// terminal.reader.action_updated
    /// </summary>
    public static readonly StripeEventType TerminalReaderActionUpdated = new("terminal.reader.action_updated");

    /// <summary>
    /// test_helpers.test_clock.advancing
    /// </summary>
    public static readonly StripeEventType TestHelpersTestClockAdvancing = new("test_helpers.test_clock.advancing");

    /// <summary>
    /// test_helpers.test_clock.created
    /// </summary>
    public static readonly StripeEventType TestHelpersTestClockCreated = new("test_helpers.test_clock.created");

    /// <summary>
    /// test_helpers.test_clock.deleted
    /// </summary>
    public static readonly StripeEventType TestHelpersTestClockDeleted = new("test_helpers.test_clock.deleted");

    /// <summary>
    /// test_helpers.test_clock.internal_failure
    /// </summary>
    public static readonly StripeEventType TestHelpersTestClockInternalFailure = new("test_helpers.test_clock.internal_failure");

    /// <summary>
    /// test_helpers.test_clock.ready
    /// </summary>
    public static readonly StripeEventType TestHelpersTestClockReady = new("test_helpers.test_clock.ready");

    /// <summary>
    /// topup.canceled
    /// </summary>
    public static readonly StripeEventType TopupCanceled = new("topup.canceled");

    /// <summary>
    /// topup.created
    /// </summary>
    public static readonly StripeEventType TopupCreated = new("topup.created");

    /// <summary>
    /// topup.failed
    /// </summary>
    public static readonly StripeEventType TopupFailed = new("topup.failed");

    /// <summary>
    /// topup.reversed
    /// </summary>
    public static readonly StripeEventType TopupReversed = new("topup.reversed");

    /// <summary>
    /// topup.succeeded
    /// </summary>
    public static readonly StripeEventType TopupSucceeded = new("topup.succeeded");

    /// <summary>
    /// transfer.created
    /// </summary>
    public static readonly StripeEventType TransferCreated = new("transfer.created");

    /// <summary>
    /// transfer.reversed
    /// </summary>
    public static readonly StripeEventType TransferReversed = new("transfer.reversed");

    /// <summary>
    /// transfer.updated
    /// </summary>
    public static readonly StripeEventType TransferUpdated = new("transfer.updated");

    /// <summary>
    /// treasury.credit_reversal.created
    /// </summary>
    public static readonly StripeEventType TreasuryCreditReversalCreated = new("treasury.credit_reversal.created");

    /// <summary>
    /// treasury.credit_reversal.posted
    /// </summary>
    public static readonly StripeEventType TreasuryCreditReversalPosted = new("treasury.credit_reversal.posted");

    /// <summary>
    /// treasury.debit_reversal.completed
    /// </summary>
    public static readonly StripeEventType TreasuryDebitReversalCompleted = new("treasury.debit_reversal.completed");

    /// <summary>
    /// treasury.debit_reversal.created
    /// </summary>
    public static readonly StripeEventType TreasuryDebitReversalCreated = new("treasury.debit_reversal.created");

    /// <summary>
    /// treasury.debit_reversal.initial_credit_granted
    /// </summary>
    public static readonly StripeEventType TreasuryDebitReversalInitialCreditGranted = new("treasury.debit_reversal.initial_credit_granted");

    /// <summary>
    /// treasury.financial_account.closed
    /// </summary>
    public static readonly StripeEventType TreasuryFinancialAccountClosed = new("treasury.financial_account.closed");

    /// <summary>
    /// treasury.financial_account.created
    /// </summary>
    public static readonly StripeEventType TreasuryFinancialAccountCreated = new("treasury.financial_account.created");

    /// <summary>
    /// treasury.financial_account.features_status_updated
    /// </summary>
    public static readonly StripeEventType TreasuryFinancialAccountFeaturesStatusUpdated = new("treasury.financial_account.features_status_updated");

    /// <summary>
    /// treasury.inbound_transfer.canceled
    /// </summary>
    public static readonly StripeEventType TreasuryInboundTransferCanceled = new("treasury.inbound_transfer.canceled");

    /// <summary>
    /// treasury.inbound_transfer.created
    /// </summary>
    public static readonly StripeEventType TreasuryInboundTransferCreated = new("treasury.inbound_transfer.created");

    /// <summary>
    /// treasury.inbound_transfer.failed
    /// </summary>
    public static readonly StripeEventType TreasuryInboundTransferFailed = new("treasury.inbound_transfer.failed");

    /// <summary>
    /// treasury.inbound_transfer.succeeded
    /// </summary>
    public static readonly StripeEventType TreasuryInboundTransferSucceeded = new("treasury.inbound_transfer.succeeded");

    /// <summary>
    /// treasury.outbound_payment.canceled
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentCanceled = new("treasury.outbound_payment.canceled");

    /// <summary>
    /// treasury.outbound_payment.created
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentCreated = new("treasury.outbound_payment.created");

    /// <summary>
    /// treasury.outbound_payment.expected_arrival_date_updated
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentExpectedArrivalDateUpdated = new("treasury.outbound_payment.expected_arrival_date_updated");

    /// <summary>
    /// treasury.outbound_payment.failed
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentFailed = new("treasury.outbound_payment.failed");

    /// <summary>
    /// treasury.outbound_payment.posted
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentPosted = new("treasury.outbound_payment.posted");

    /// <summary>
    /// treasury.outbound_payment.returned
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentReturned = new("treasury.outbound_payment.returned");

    /// <summary>
    /// treasury.outbound_payment.tracking_details_updated
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundPaymentTrackingDetailsUpdated = new("treasury.outbound_payment.tracking_details_updated");

    /// <summary>
    /// treasury.outbound_transfer.canceled
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferCanceled = new("treasury.outbound_transfer.canceled");

    /// <summary>
    /// treasury.outbound_transfer.created
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferCreated = new("treasury.outbound_transfer.created");

    /// <summary>
    /// treasury.outbound_transfer.expected_arrival_date_updated
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferExpectedArrivalDateUpdated = new("treasury.outbound_transfer.expected_arrival_date_updated");

    /// <summary>
    /// treasury.outbound_transfer.failed
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferFailed = new("treasury.outbound_transfer.failed");

    /// <summary>
    /// treasury.outbound_transfer.posted
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferPosted = new("treasury.outbound_transfer.posted");

    /// <summary>
    /// treasury.outbound_transfer.returned
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferReturned = new("treasury.outbound_transfer.returned");

    /// <summary>
    /// treasury.outbound_transfer.tracking_details_updated
    /// </summary>
    public static readonly StripeEventType TreasuryOutboundTransferTrackingDetailsUpdated = new("treasury.outbound_transfer.tracking_details_updated");

    /// <summary>
    /// treasury.received_credit.created
    /// </summary>
    public static readonly StripeEventType TreasuryReceivedCreditCreated = new("treasury.received_credit.created");

    /// <summary>
    /// treasury.received_credit.failed
    /// </summary>
    public static readonly StripeEventType TreasuryReceivedCreditFailed = new("treasury.received_credit.failed");

    /// <summary>
    /// treasury.received_credit.succeeded
    /// </summary>
    public static readonly StripeEventType TreasuryReceivedCreditSucceeded = new("treasury.received_credit.succeeded");

    /// <summary>
    /// treasury.received_debit.created
    /// </summary>
    public static readonly StripeEventType TreasuryReceivedDebitCreated = new("treasury.received_debit.created");

    /// <summary>
    /// billing.credit_balance_transaction.created
    /// </summary>
    public static readonly StripeEventType BillingCreditBalanceTransactionCreated = new("billing.credit_balance_transaction.created");

    /// <summary>
    /// billing.credit_grant.created
    /// </summary>
    public static readonly StripeEventType BillingCreditGrantCreated = new("billing.credit_grant.created");

    /// <summary>
    /// billing.credit_grant.updated
    /// </summary>
    public static readonly StripeEventType BillingCreditGrantUpdated = new("billing.credit_grant.updated");

    /// <summary>
    /// billing.meter.created
    /// </summary>
    public static readonly StripeEventType BillingMeterCreated = new("billing.meter.created");

    /// <summary>
    /// billing.meter.deactivated
    /// </summary>
    public static readonly StripeEventType BillingMeterDeactivated = new("billing.meter.deactivated");

    /// <summary>
    /// billing.meter.reactivated
    /// </summary>
    public static readonly StripeEventType BillingMeterReactivated = new("billing.meter.reactivated");

    /// <summary>
    /// billing.meter.updated
    /// </summary>
    public static readonly StripeEventType BillingMeterUpdated = new("billing.meter.updated");

    /// <summary>
    /// ping
    /// </summary>
    public static readonly StripeEventType Ping = new("ping");
}