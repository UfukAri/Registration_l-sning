# Registration_l-sning
Dette er vår løsning til obligatoriske oppgaven, vi ble utdelt i faget Webapplikasjon, høst 2018.

Vi fikk i oppgave å lage e film applikasjon, der kunde må være logget inn for å få fullført kjøp.

Vi i gruppen har arbeidet godt og trygt gjennom hele prosessen.
Men desverre møtte vi på problemer som Azure og Amazon, som hadde vanskeligheter med å veiledet oss til å bruke student skyen som dem påstår å være gratis for studenter.
På denne måten fikk vi ikke lagt ut applikasjonen vår i noen som helst cloud. Noe som innbærer at databasen vil mest sannesynelig være tom, når du mottar denne løsningen. 
Dette er da litt krise, tanke på at det ikke er noen  filmer i databasen. 
Vi har heller gjort det slik at vi har laget en metode, slik at man kan få lagdt inn filmer inn til databasen. Bildene på filmene er da lagret i content mappen.

Fremgangsmåten for å kjøre filen korrekt:

1. Første steget vil være å gå inn på siden til legg film: http://localhost:54282/Bestilling/Leggfilm
2. Legg til title på film, pris, kategori, beskrivelse av filmen og bildet av filemn,s om du finner på content mappen, du kan skrive inn følgende i input-feltet: ~/Content/Pictures/conguring.jpg

Et eksempel du kan føre inn, for å sjekke om det stemmer er følgende:

Tittel: Avengers
Pris:  150
Kategory: Action
Beksrivelse: Hva som helst kan føres inn her.
Image: ~/Content/Pictures/avengers.jpg

Tittel: 21 Jumpstreet
Pris:  200
Kategory: Komedie
Beksrivelse: Hva som helst kan føres inn her.
Image: ~/Content/Pictures/21jump.jpg

Tittel: Conguering
Pris:  250
Kategory: Horror
Beksrivelse: Hva som helst kan føres inn her.
Image:~/Content/Pictures/conguring.jpg

Merk: Du kan ikke legge til samme film to ganger.


I felte kategory har vi en metode, som sjekker opp mot om Action, Komedie og Horror er riktig skrevet. Derfor er det da viktig at dette blir skrevet inn ritkig i felte kategory.
Dette skal da egentlig være grunnmuren til første siden vår, der førstesiden er basert på rekke filmer, som kunden kan velge mellom. Men igjen fikk vi ikke til skytjenesten, som kunne beholdt alle filmene.
Det er også langt til en hyperlink, som viser hvilke filmer du lagt inn i databasen. 


Til neste oblig vil vår første prioritert å få løst dette med skytjenesten. Vi har som gruppeprøvd å opfylle alle krav til det oppgaven ber oss om. Noe vi i gruppen føler har mestrert.
Men igjen er det forbedring potensiell i løsningen, som vi da skal utføre til neste oblig. 

Beklager igjen for alt styret, og er selvfølgelig åpne for å svare på spørsmål som skulle dukke opp ved rettelse av oppgaven.

Gruppemedlemmer:
s305519 - Ufuk Ari
s310058 - Idris Hamed
s325272 - Jebril Abdishakur Mohammed

