[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.eventtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.eventtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.eventtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.eventtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.eventtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.eventtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.eventtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.eventtypes/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.EventTypes

Provides strongly typed values for Stripe event names used by webhooks and the Events API, spanning payments, billing, customers, Connect, Checkout, disputes, payouts, and more.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.EventTypes
```

## Usage

```csharp
using Soenneker.Stripe.Enums.EventTypes;

if (StripeEventType.TryFromValue(stripeEvent.Type, out StripeEventType? type))
{
    if (type == StripeEventType.PaymentIntentSucceeded)
    {
        // Process the verified event idempotently.
    }
}
```

Always verify the Stripe webhook signature before dispatching on an event type, and make handlers idempotent because Stripe can deliver the same event more than once. Use `TryFromValue` so newly introduced event names can follow an explicit fallback path.
