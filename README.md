# Les1-8Tutorial

# Ik heb opdracht 1 gedaan:
Assets/Scripts/Coins.cs
 Ik heb een Unity-scène gemaakt met een speler (cube) en het script PlayerScore. In dat script houd ik de score bij met een variabele, check ik met een if-statement of de speler gewonnen heeft (bij 50 punten), laat ik via een loop drie startberichten zien, en gebruik ik een functie om munten toe te voegen aan een List. Alles werkt: bij spatie wordt een munt toegevoegd, en bij 50 punten zie je een win-bericht.
 
![9wiet4](https://github.com/user-attachments/assets/81f7b8a1-e1e1-474f-8d65-ecb54fa42f0e)

## Ik heb opdracht 2/3 gedaan:
Assets/Scripts/Gamemanager.cs
Assets/Scripts/Les2.cs
Ik heb een Unity-scène gemaakt met een speler (cube) die beweegt met de pijltjestoetsen en springt met de spatiebalk. Ik heb een Rigidbody toegevoegd voor physics, en de speler blijft netjes op de vloer. In het script verwerk ik input, gebruik ik componenten zoals Rigidbody, en heb ik moveSpeed en jumpForce public gemaakt zodat ik ze in de Inspector kan aanpassen. Ook heb ik Debug.Log("Springen!") toegevoegd om te checken of springen werkt.

Ik heb een scène gemaakt met een speler (cube) die beweegt via Vector3 met de pijltjestoetsen, en munten verzamelt met triggers. In het script houd ik de score en een timer van 20 seconden bij met Time.deltaTime. Elke keer als ik een munt pak, stijgt de score, en in de console zie ik de tijd en score. Als de tijd op is, verschijnt "Game Over" in de console. Ik heb speed en timeLeft public gemaakt, een derde munt toegevoegd, en met CompareTag("Coin") gecontroleerd of het een munt is. Ook heb ik muren geplaatst en de camera goed gepositioneerd zodat alles zichtbaar is.

![9wievi](https://github.com/user-attachments/assets/729371a0-c776-4c98-8483-387ab5395beb)


## Ik heb opdracht 4 gedaan:
Assets/Scripts/SceneSwitcher.cs

Ik heb twee scènes gemaakt: een StartScene en een GameScene. In de StartScene gebruik ik een script (SceneSwitcher) om met spatie naar de GameScene te gaan. In de GameScene beweegt de speler met pijltjestoetsen, en ik spawn een munt-prefab op een random positie. De snelheid van de speler is aanpasbaar via een public variabele of met [SerializeField]. Ik heb beide scènes toegevoegd aan de Build Settings, en in de uitbreiding heb ik de snelheid aangepast en 30 munten gespawned. Alles werkt zoals verwacht.

![9wifav](https://github.com/user-attachments/assets/82df5077-8c2a-4ae2-84f6-72fe418a803b)


## Ik heb opdracht 5 gedaan:
Assets/Scripts/PlayerMove.cs
Assets/Scripts/ScoreManager.cs

Ik heb een scène gemaakt waarin een speler (cube) beweegt en munten verzamelt. De code is netjes verdeeld over twee scripts: PlayerMove.cs regelt de beweging en ScoreManager.cs houdt de score bij. Ik heb gebruikgemaakt van referenties tussen scripts (de speler verwijst naar het score-object), en alles is voorzien van duidelijke comments en Debug.Log-outputs. In Start() controleer ik of speed goed is ingesteld. Tijdens het testen heb ik expres de scoreManager niet ingevuld om de foutmelding te zien en opgelost aan de hand van de console. Alles werkt en is gestructureerd opgezet.

![9wiffl](https://github.com/user-attachments/assets/0d318056-8e83-4e6b-bf08-212cea001082)


 ![9wifgd](https://github.com/user-attachments/assets/1919d010-f073-46df-9e96-a1b02bf21fe2)









