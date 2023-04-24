# Domain Models

## Subscription

```json
{
  "id": "0000000-0000-0000-0000-00000000000",
  "previousStatus": "TRIAL",
  "isActive": true,
  "isSubscribed": true,
  "emailSubscribedWith": "nader.laroussi@gmail.com",
  "stripeCustomerId": "XV588CC2D",
  "beginSubscriptionDate": "2023-04-22",
  "endSubscriptionDate": null,
  "usageConso": {
    "activeUsers": 5,
    "countAgencies": 5,
    "remainingInvitation": 5,
    "remainingApiKeys": 5
  },
  "currentPlan": {
    "type": "PREMIUM",
    "currency": "EUR",
    "pricePerMonth": 480,
    "pricePerYear": 3400,
    "period": 3,
    "description": "Une description du Plan"
  },
  "createdAt": "2023-04-22",
  "updatedAt": "2023-04-22"
}
```

## Agency

```json
{
  "id": "0000000-0000-0000-0000-00000000000",
  "name": "Humaxoo",
  "size": "BTW_10_20",
  "isHeadQuarter": true,
  "isActive": true,
  "officialEmail": "nader.laroussi@gmail.com",
  "officialPhoneNumber": {
    "code": "+33",
    "number": "659988542"
  },
  "address": {
    "street": "10 Rue Blaise Pascal",
    "street_2": null,
    "zipCode": "94500",
    "city": "Champigny-sur-Marne",
    "country": "FR"
  },
  "createdAt": "2023-04-22",
  "updatedAt": "2023-04-22"
}
```

## User

```json
{
  "id": "0000000-0000-0000-0000-00000000000",
  "subscriptionId": "0000000-0000-0000-0000-00000000000",
  "agencyId": "0000000-0000-0000-0000-00000000000",
  "firstName": "Nader",
  "lastName": "Laroussi",
  "roles": ["CUST_OWNER"],
  "email": "nader.laroussi@gmail.com",
  "hash": "hashedZayd2017#",
  "phoneNumber": {
    "code": "+33",
    "number": "659988542"
  },
  "isActive": true,
  "createdAt": "2023-04-22",
  "updatedAt": "2023-04-22"
}
```

### Roles

```csharp
public enum ROLES {
    HXOO = 'HXOO',
    OWNER = 'OWNER',
    ADMIN = 'ADMIN',
    CONSULTANT = 'CONSULTANT'
}
```

### SubscriptionStatus

```csharp
public enum SUBSCRIPTION_STATUS {
    TRIAL,
    PURCHASED
}
```

### CompanySizes

```csharp
public enum CompanySizes {
    ONE = 'ONE',
    BTW_2_10 = 'BTW_2_10',
    BTW_11_50 = 'BTW_11_50',
    BTW_51_100 = 'BTW_51_100',
    BTW_101_250 = 'BTW_101_250',
    BTW_251_500 = 'BTW_251_500',
    BTW_501_1000 = 'BTW_501_1000',
    MORE_THAN_1000 = 'MORE_THAN_1000'
}
```
