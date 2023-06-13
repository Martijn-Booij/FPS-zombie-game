# Logboek: FPS Shooter Zombie game

## Vrijdag | 09-06-2023

- Implementeerde de `PlayerManager`-klasse met de functionaliteit om de gezondheid van de speler bij te houden en schade toe te passen.
- Voegde een referentie naar de `GameManager` toe aan de `PlayerManager` om de `EndGame()`-methode aan te roepen wanneer de speler doodgaat.
- Schreef commentaarregels om de functionaliteit van elke sectie in de `PlayerManager` te beschrijven.
- Research naar assets om te gebruiken
- Assets implementeren

## Zaterdag | 10-06-2023

- Implementeerde de `ZombieManager`-klasse met de functionaliteit om vijandige zombies te beheren.
- Voegde een referentie naar de speler toe en gebruikte de `NavMeshAgent` om de vijanden naar de speler te laten bewegen.
- Voegde logica toe om schade toe te passen op de speler bij een botsing met een zombie.
- Voegde logica toe om de gezondheid van de zombie bij te houden en de vijand te markeren als dood wanneer de gezondheid nul bereikt.
- Voegde referenties naar de `GameManager` en de `Animator`-component toe aan de `ZombieManager`.
- Schreef commentaarregels om de functionaliteit van elke sectie in de `ZombieManager`-klasse te beschrijven.

## Zondag | 11-06-2023

- Voegde functionaliteit toe aan de `GameManager` om het aantal levende zombies bij te houden en het volgende golfpatroon te activeren wanneer er geen zombies meer zijn.
- Implementeerde de `NextWave()`-methode in de `GameManager` om nieuwe zombies te spawnen voor elke volgende ronde.
- Schreef commentaarregels om de functionaliteit van elke sectie in de `GameManager`-klasse te beschrijven.

## Maandag | 12-06-2024

- Implementeerde de `MainMenuManager`-klasse met functionaliteit voor het starten van het spel en het afsluiten van de applicatie.
- Voegde commentaarregels toe om de functionaliteit van elke methode in de `MainMenuManager`-klasse te beschrijven.
- Voegde logica toe om het spel te winnen wanneer het aantal rondes 10 bereikt.

## Dinsdag | 13-06-2024

- Werkte de `GameManager` bij om de eindschermen (WinScreen en EndScreen) weer te geven en het aantal gedode zombies en overleefde rondes weer te geven.
- Voegde commentaarregels toe om de functionaliteit van de eindschermen in de `GameManager`-klasse te beschrijven.
- Testte de gamefunctionaliteit en zorgde ervoor dat alles soepel werkt.


# Testverslagen

| Wie   | Wat                   | Uitkomst                                                                 |
|-------|-----------------------|--------------------------------------------------------------------------|
| Broer | Geweer schieten       | Positief. Het geweer schoot.                                            |
| Broer | Zombies schieten      | Positief. De zombie gaat dood nadat er 2 keer op hem is geschoten.       |
| Broer | Ronde halen           | Positief. Nadat alle zombies dood zijn, wordt automatisch een nieuwe ronde gestart. |
| Broer | Dood gaan             | Positief. De speler gaat dood zodra zijn gezondheid op 0 staat. Dit resulteert in een scherm waar de speler het opnieuw kan proberen. |
| Broer | Overleven             | Positief. Zodra ronde 10 is gehaald, verschijnt er een scherm waarop staat dat de speler heeft gewonnen. De speler kan vervolgens opnieuw proberen. |

