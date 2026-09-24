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