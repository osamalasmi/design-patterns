# Design Patterns

Uitgewerkte design pattern opdrachten in C#, geschreven voor mijn opleiding Software Development.

## Projecten

| Map | Pattern | Waar gaat het over |
|---|---|---|
| `StrategyPattern` | Strategy | Ducks met verwisselbaar fly- en quack-gedrag |
| `StrategyPatternPaymentMethod` | Strategy | Betaalmethodes die je kunt omwisselen in een `BetaalProcessor` |
| `ObserverPattern` | Observer | `WeatherData` die meerdere displays op de hoogte houdt |
| `AdapterPattern` | Adapter | Turkeys en Geese aanpassen zodat ze als Duck gebruikt kunnen worden |
| `DecoratorNotificationApp` | Decorator | Notificaties uitbreiden met extra gedrag via decorators |
| `FacadePattern` | Facade | `HomeTheaterFacade` met `WatchMovie` en `EndMovie` |
| `FacadePattern1` | Facade | `GameFacade` voor subsystemen als audio, graphics en netwerk (zie `FacadePatternReflection.md`) |
| `Singleton` | Singleton | `ChocolateBoiler` als Singleton, thread-safe met double checked locking (alternatieven: synchronized method, eager instantiation) |
| `FactoryNotificationApp` | Factory | Notificatiefactory met vaste combinaties (in ontwikkeling) |
| `NotificationApp` | - | Basisproject met losse notificatieservices (email, sms, push, WhatsApp) |

## Vereisten

[.NET 10 SDK](https://dotnet.microsoft.com/download) (alle projecten gebruiken `net10.0`).

## Structuur

Elke map is een los .NET-project met zijn eigen `.csproj`. Open de map van het pattern dat je wil bekijken direct in VS Code (of Visual Studio), niet de hele repo-root, om build-conflicten te voorkomen.

## Runnen

Elk project draai je los vanuit zijn eigen map:

```bash
cd <NaamVanDeMap>
dotnet run
```

## Auteur

Osama Alasmi
