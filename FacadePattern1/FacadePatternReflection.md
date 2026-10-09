# Facade Pattern - Reflectie

## Welke problemen beginnen te ontstaan in je code?

Ik moet voor elke class steeds opnieuw de methods initialiseren. Alles is los
van elkaar, de classes communiceren niet met elkaar. `Program.cs` moet zelf
elke class aanmaken en precies weten in welke volgorde alles moet gebeuren.

## Hoe zou je die problemen kunnen oplossen?

Ik dacht aan een koppel-class maken. Bijvoorbeeld een `StartGame`, en daar
alle initialisaties in zetten. Dan hoef je in `Program.cs` alleen nog die
ene class te initialiseren, in plaats van steeds alle losse classes zelf
aan te roepen.

## Facade vs Adapter

**Verschillen**
- **Adapter** maakt een bestaande class passend bij een interface die er niet bij past (bijv. `Turkey` → `Duck`).
- **Facade** verzamelt meerdere subsystemen achter één simpele class (bijv. `StartGame()`).
- Adapter pakt meestal één class in, Facade meerdere.

**Overeenkomsten**
- Beide gebruiken een HAS-A-relatie.
- Bij beide hoef je de bestaande classes niet aan te passen.
- De client weet niet wat erachter zit, waardoor de code overzichtelijker wordt.