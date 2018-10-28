Admin-bruker for Tor Krattebøl 
•	Epost: Admin@MovieChill.no
•	Passord = admin123

Her er vår løsning for obligatorisk oppgave i faget Webapplikasjon, høst 2018.

Vi har fått satt på intializer metode(Seed), som gjør at filmer blir lastet opp ved applikasjon oppstart. Men får å få dette til å gå, må du gå inn i DAL mapen, så til DBinit, og bytte om CreateDabaseIfNotExits til DropDatabaseAlways. Så kjøre programmet. Hvis da ikke filmene dukker opp, må man da lukke og kjøre programmet på nytt. Det har en tendens for å gå etter andre oppstart av applikasjonen. Når man da får opp filmene, må man da bytte DropDatabaseAlways tilbake til CreateDatabaseIfNotExits.

Man kan da logge seg som Admin, og ha muligheten til å:
•	Endre og slette Kunder
•	Endre og slette filmer
•	Logg for endringer i databasen
•	Legge til filmer
•	Se bestillinger som kunder har gjort
Logg for feilsituasjoner ble dessverre nedprioritert, siden oppgaven ble litt for stor til å rekke fristen. Ble en del feilmeldinger/bug som dukket opp gjennom prosjektet, som vi brukte tid til å rette. Men dette er et punkt, som hadde vært vårt hovedfokus frem i tid. 

Legge til film: 
Som det var i første obligen er det visse retningslinjer man må gjør for å legge til bilder(image) til fimene man ønsker å legge til. Vi kunne løst dette med å lage en input type=’’file’’, som da laster opp bildet. Men dette ble da dessverre nedprioritert på grunn av, ikke nok tid.   

Fremgangsmåten for å legge til image, ved legg til ny film:
1.	Første steget vil være å gå inn på siden til legg film: http://localhost:54282/Bestilling/Leggfilm
2.	Legg til title på film, pris, kategori, beskrivelse av filmen og bildet av filemen som du finner på content mappen, du kan skrive inn følgende i input-feltet: ~/Content/Pictures/conguring.jpg
Et eksempel du kan føre inn, for å sjekke om det stemmer er følgende:

Tittel: Avengers 
Pris: 150 
Kategory: Action 
Beksrivelse: Hva som helst kan føres inn her. 
Image: ~/Content/Pictures/avengers.jpg
OBS/Merk: Du kan ikke legge til samme film to ganger.
Håper koden er lett å forstå, og vi er selvfølgelig åpne for å svare på spørsmål som skulle dukke opp ved rettelse av oppgaven.
Gruppemedlemmer: 
s305519 - Ufuk Ari
 s310058 - Idris Hamed 
s325272 - Jebril Abdishakur Mohammed

