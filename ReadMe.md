
# Login-system

Vi kodar ett enkelt login-system! Systemet skall ta in användarnamn och lösenord och avgöra om vi får gå vidare utifrån om de inmatade uppgifterna stämmer överens med vad som finns i "databasen". Databasen kan fyllas med en eller fler test-användare, så systemet behöver också kunna lägga till nya användare.
Grunden till detta system kan starkt inspireras av vår Todo-app!

# Steg 1

* Gör en klass för användare (User)
* Gör en klass för login-systemet (Den som har hand om User, lägga till  användare, samt ha en metod i stil med Login(username, password);
* I Program.cs skall du nu använda dessa klasser för att i kod lägga till några användare (det kan alltså ske automatiskt, utan användarinput, exempelvis loginSystem.AddUser("john", "thepasswordisalie"), eller loginSystem.AddUser(user);
*I Program.cs skall du nu göra ett enkelt gränssnitt där du får först skriva in Användarnamn: och sedan Lösenord:. Om det stämmer går du vidare och skriver ut någon text i stil med "Inloggningen lyckades!".

# Steg 2

* Prova att lyfta över ditt inloggningssystem till ett annat consol-projekt du gjort, exempelvis Byrån, så att du måste logga in för att kunna använda applikationen.

# Steg 3

* Vilka mer avancerade funktioner kan du vilja lägga till?
Exempelvis: Max antal inloggningar innan kontot fryses?
Logga tid och datum för felaktiga inloggningar?