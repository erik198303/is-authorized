## Övning metod

Skriv en metod isAuthorised som frågar användaren efter tre lösenord och som kontrollerar om alla tre är korrekta. Ni får själva bestämma 
vilka de rätta lösenorden är. Metoden ska returnera true om användaren lyckades, och false annars. 
Anropa isAuthorised()-metoden från er main-metod, och skriv ut en lämplig gratulationsfras ifall användaren lyckats mata in alla lösenorden
korrekt. Om användaren inte lyckades ska programmet låta henne försöka fyra gånger till (antalet totala inloggningsförsök man har på sig är fem).

Tips 1: ni bör hålla räkningen på hur många försök användaren hittils har förbrukat.

Tips 2: använd loopar.

## Utöka övningen

Gör så att ordningen användaren matar in lösenorden i inte spelar någon roll - om lösenorden är “piggy”, “snuff” och “bark” så ska ordningen “snuff”,”bark”,”piggy” också accepteras.
