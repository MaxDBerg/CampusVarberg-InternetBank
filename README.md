# CampusVarberg-InternetBank

- [ ]  När programmet startar ska användaren välkomnas till banken
- [ ]  Användaren ska mata in sitt användarnummer/användarnamn (valfritt hur detta ser ut) och en pin-kod som ska avgöra vilken användare det är som vill använda bankomaten
- [ ]  Bankomaten ska ha 5 olika användare  som ska kunna använda den. Det behöver inte gå att lägga till fler användare.
- [ ]  Om användaren skriver in fel pinkod tre gånger ska det inte gå att försöka logga in igen utan att starta om programmet.

- [ ]  När användaren lyckats logga in ska bankomaten fråga vad användaren vill göra. Det ska finnas fyra val:
    
    ```csharp
    1. Se dina konton och saldo
    2. Överföring mellan konton
    3. Ta ut pengar
    4. Logga ut
    ```
    
- [ ]  Användaren ska kunna välja en av funktionerna ovan genom att skriva in en siffra.
- [ ]  När en funktion har kört klart ska användaren få upp texten "Klicka enter för att komma till huvudmenyn". När användaren klickat enter kommer menyn upp igen.
- [ ]  Om användaren väljer "Logga ut" ska programmet inte stänga av. Användaren ska komma till inloggningen igen.
- [ ]  Om användaren skriver ett nummer som inte finns i menyn, eller något annat än ett nummer, ska systemet meddela att det är ett "ogiltigt val".
