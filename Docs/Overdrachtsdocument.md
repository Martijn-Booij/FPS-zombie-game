Overdrachtsdocument - Zombie FPS Shooter Game

Projectnaam: Zombie FPS Shooter

Doel:
Het doel van dit project is het ontwikkelen van een Zombie FPS Shooter game in Unity. De speler moet zombies doden en ronden overleven om het spel te winnen.

Functionaliteiten:
1. Geweer schieten:
   - De speler kan schieten met het geweer.
   - Het geweer schiet enigszins accuraat en veroorzaakt schade aan zombies.

2. Zombies schieten:
   - Wanneer de speler op een zombie schiet, wordt de gezondheid van de zombie verminderd.
   - Na twee schoten gaat de zombie dood.

3. Ronde halen:
   - Nadat alle zombies dood zijn, start automatisch een nieuwe ronde.
   - Het aantal ronden wordt bijgehouden.

4. Dood gaan:
   - Als de gezondheid van de speler op 0 staat, gaat de speler dood.
   - Er wordt een scherm weergegeven waarop de speler het opnieuw kan proberen.

5. Overleven:
   - Als de speler ronde 10 haalt, wordt er een scherm weergegeven waarop staat dat de speler heeft gewonnen.
   - De speler kan het spel opnieuw proberen.

Belangrijke bestanden:
1. GameManager.cs:
   - Bevat de logica voor het beheren van de ronden, het winnen en verliezen van het spel, evenals het bijhouden van het aantal gedode zombies.

2. PlayerManager.cs:
   - Bevat de logica voor het beheren van de gezondheid van de speler en het controleren van de doodconditie.

3. ZombieManager.cs:
   - Bevat de logica voor het gedrag van zombies, inclusief het volgen van de speler en het controleren van de doodconditie van zombies.

Toekomstige ontwikkeling:
- Verbetering van de gameplay door het toevoegen van nieuwe wapens en power-ups.
- Implementatie van verschillende zombie-typen met unieke eigenschappen.
- Toevoegen van levels en omgevingen om de speelervaring te diversifiëren.

