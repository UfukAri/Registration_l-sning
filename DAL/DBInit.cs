using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DBInit : DropCreateDatabaseAlways<DB>
    {
        
        protected override void Seed(DB context)
        {

            var adrisse = new Poststed
            {
                Id = 3,
                PostNr = 312,
                PostSted = "Oslo",
            };


            //Action:
            var film1 = new Film
            {
                Title = "Advengers",
                Catrgory = "Action",
                Pris = 150,
                Discription = "Etter en ti هr lang og unik filmatisk reise i hele Marvel-universet kommer nه Marvel Studios med Avengers: Infinity War, tidenes ultimate og dّdeligste konfrontasjon. " +
                "Vهre Avengers-helter mه nه vوre villige til ه ofre alt i kampen mot den mektige Thanos, fّr hans totale ondskap ّdelegger hele vهrt univers. ",
                Image = "~/Content/Pictures/avengers.jpg"
            };



            var film2 = new Film
            {
                Title = "Black Panther",
                Catrgory = "Action",
                Pris = 150,
                Discription = "Nهr en mektig, gammel fiende vender tilbake blir T'Challas evner som konge - og Black Panther - satt pه prّve. Han blir dratt inn i en formidabel konflikt som setter Wakanda og hele verdens skjebne i fare." +
                "Stilt overfor forrوderi og fare, mه den unge kongen samle sine allierte og slippe Black Panthers fulle kraft fri for ه beseire sine fiender og besّrge sitt folks sikkerhet og livsstil. ",
                Image = "~/Content/Pictures/Black.jpg"
            };

            var film3 = new Film
            {
                Title = "The equalizer",
                Catrgory = "Action",
                Pris = 150,
                Discription = "McCall (Denzel Washington) er en tidligere black ops-kommandant som har faket sin egen dّd for ه kunne leve et rolig, anonymt liv i Boston." +
                " Nهr den unge jenta Teri (Chloë Grace Moretz) forsvinner fra nabolaget, bryter han protokollen sin og oppsّker de ultravoldelige, russiske gangsterne han mistenker har noe med saken ه gjّre." +
                " De gamle instinktene hans vekkes til live igjen nهr han innleder et hevnkorstog mot alle som har gjort henne - og andre uskyldige mennersker - urett." +
                " Hvis noen har et problem, oddsene er imot dem og de ikke har noen andre ه henvende seg til, sه vil McCall hjelpe. Han er The Equalizer.",
                Image = "~/Content/Pictures/equalizer.jpg"
            };

            var film4 = new Film
            {
                Title = "Iron Man 2",
                Catrgory = "Action",
                Pris = 150,
                Discription = "Nه som hele verden kjenner til at industrimagnaten Tony Stark (Robert Downey Jr.) er Iron Man, ّnsker Tony ه fremheve Iron Man draktens teknologiske fortrinn ved ه relansere sin avdّde fars Stark Expo. " +
                "Stark Expo er en utstilling for humanitوre nyutviklinger inspirert av denne teknologien. Mens den amerikanske regjeringen insisterer pه at Tony skal overdra det revolusjonerende vهpenet til de militوre myndighetene," +
                "gهr Ivan Vanko (Mickey Rourke), en mystisk skikkelse fra Stark familiens fortid, inn for ه knuse Tony ved ه avslّre sitt eget ّdeleggelsesvهpen basert pه Starks teknologi.",
                Image = "~/Content/Pictures/iron.jpg"
            };

            var film5 = new Film
            {
                Title = "Logon",
                Catrgory = "Action",
                Pris = 150,
                Discription = "I en nوrliggende fremtid, har den slitne Logan pهtatt seg omsorgen for en skrantende Professor X fra et skjulested ved den mexikanske grensen. " +
                "Men Logans forsّk pه ه gjemme seg fra samfunnet blir problematisk nهr han krysser vei med en ung mutant som blir forfulgt av mّrke krefter.",
                Image = "~/Content/Pictures/Logan.jpg"
            };

            var film6 = new Film
            {
                Title = "Mission: Impossible - Ghost Protocol",
                Catrgory = "Action",
                Pris = 150,
                Discription = "Agenten Ethan Hunt og teamet hans fهr skylden for terroristbombingen av Kreml. Hele organisasjonen han arbeider for avvikles nهr presidenten kort tid etter annonserer Ghost Protocol." +
                "Uten noen ressurser eller forsterkninger til rهdighet, mه Ethan finne en mهte ه renvaske navnet til byrهet sitt og forhindre et nytt terrorangrep. " +
                "For ه komplisere saken ytterligere tvinges Ethan ut pه et farlig oppdrag sammen med andre tidligere agentkolleger pه flukt fra myndighetene. Men han vet ingenting om deres personlige motivasjoner.",
                Image = "~/Content/Pictures/MissionImp.jpg"
            };

            var film7 = new Film
            {
                Title = "Pacific Rim: Uprising",
                Catrgory = "Action",
                Pris = 150,
                Discription = "Ti هr har gهtt siden de gigantiske Kaiju-monstrene steg opp fra havet og la verdens storbyer i ruiner. Etter at de ble utslettet av de gigantiske Jaeger-robotene, har situasjonen normalisert seg igjen. Men Jaeger-teamet hviler ikke." +
                " Jake Pentecost (John Boyega) " +
                "- sّnnen av den legendariske Jaeger-piloten Stacker Pentecost - blir hentet inn mot sin vilje til ه trene opp en ny generasjon med Jaeger-kadetter. " +
                "Underveis i det som skulle vوre et rent rutineoppdrag, begynner noe ه rّre seg under havoverflaten. Storslهtt action med John Boyega (Star Wars) og Scott Eastwood (Fast & Furious) i hovedrollene.",
                Image = "~/Content/Pictures/pacific.jpg"
            };


            //Kommediet:
            var film8 = new Film
            {
                Title = "21 Jump Street",
                Catrgory = "Komedie",
                Pris = 150,
                Discription = "De gهr inn i politiets hemmelige Jump Street-enhet, og benytter seg av sitt ungdommelige utseende for ه spane pه den lokale videregهende skolen. " +
                "Vهpen og politiskilt byttes ut med skolesekker nهr Schmidt og Jenko mه risikere livet for ه etterforske en farlig narkotikaliga. " +
                "Men de finner raskt ut at skolen er totalt forandret fra den de forlot bare noen fه هr tidligere - og ingen av dem forventer ه bli konfrontert med den skrekk og angst det innebوrer ه bli en tenهring igjen, og alle problemene de trodde de hadde lagt bak seg.",
                Image = "~/Content/Pictures/21jump.jpg"
            };

            var film9 = new Film
            {
                Title = "Central intelligence",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = " En sjenert regnskapsfّrer fهr kontakt med en gammel venn pه Facebook. Fّr han vet ordet av det er han en del av en internasjonal spionliga." +
                              " Ellevill actionkomedie med Dwayne Johnson og Kevin Hart.",
                Image = "~/Content/Pictures/CI.jpg"
            };

            var film10 = new Film
            {
                Title = "Dumb and dumber to",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = "Farrelly-brّdrene er tilbake med en ny crazy historie om de to mestertullingene Harry og Lloyd, ogsه denne gang med Jim Carrey og Jeff Daniels fremst i idiotkّen. " +
                "20 هr etter den gale roadtrippen til Aspen, har Harry fهtt vite at han har voksen datter der ute." +
                "Harry begir seg ut pه ennه et eventyr sammen med sin trofaste venn Lloyd for ه finne sitt ukjente barn. Reisen skal vise seg ه ikke gه helt som planlagt." +
                "For regien stهr Bobby og Peter Farelly som i tillegg til den fّrste Dum og dummere-filmen ogsه er kjent for komediene Alle elsker Mary, Shallow Hal, Kingpin og Jeg, meg selv og Irene." +
                " Pه rollelisten finner vi i tillegg til Jim Carrey og Jeff Daniels navn som Laurie Holden, Rob Riggle og Kathleen Turner.",
                Image = "~/Content/Pictures/dumb.jpg"
            };

            var film11 = new Film
            {
                Title = "Get hard",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = "Nهr den superrike hedgefondforvalteren James (Will Ferrell) blir anholdt for svindel, frykter han et rّft opphold i San Quentin fengselet. " +
                "Dommeren gir ham 30 dager til ه fه orden pه forretningene sine og i ren desperasjon vender han seg til Darnell (Kevin Hart) for ه forberede ham pه et liv bak murene." +
                " Men til tross for James' antagelser om at alle sorte er kriminelle, er Darnell en hardtarbeidende selvstendig nوringsdrivende som aldri har fهtt sه mye som en parkeringsbot, ei heller sittet inne." +
                "Sammen gjّr de to alt i sin makt for at James skal herdes for fengsel, og i prosessen oppdager de hvor feil de har tatt om mye, inkludert om hverandre.",
                Image = "~/Content/Pictures/GH.jpg"
            };

            var film12 = new Film
            {
                Title = "Hangover",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = "To dager fّr han skal gifte seg, kjّrer Doug til Las Vegas sammen med bestekompisene Phil og Stu og sin kommende svoger Alan for et sanselّst utdrikningslag de lover seg selv aldri ه glemme." +
                "Lّftet innfris til de grader. forloverne vهkner dagen etter med dundrende vondt i hodet, husker de ingenting.Luksussuiten pه hotellet er hinsides ramponert, en ekte tiger(!) er pه badet og brudgommen er borte." +
                "Med verdens stّrste kuppelhuer prّver de ه rekonstruere hva som har skjedd. De har ikke peiling, men heller ingen tid ه miste. Trioen mه nّste opp i sine ukloke valg fra kvelden fّr for ه finne ut hvor alt gikk galt. " +
                "Kanskje har de da hهp om ه finne Doug og fه ham tilbake til Los Angeles fّr bryllupet. Men desto mer de finner ut, desto mer innser de hvor store problemer de faktisk har.",
                Image = "~/Content/Pictures/Hangover.jpg"
            };

            var film13 = new Film
            {
                Title = "Oceans 8",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = "Fem هr, هtte mهneder og tolv dager.. det er hvor lenge Debbie Ocean (Sandra Bullock) har brukt pه ه planlegge det stّrste ranet i hennes liv." +
                "Hun vet akkurat hva som mه til - en gruppe med de beste av de beste innen deres omrهde." +
                "Debbie og hennes partner -in-crime Lou Miller(Cate Blanchett), gهr sammen for ه rekruttere en gjeng med spesialister: gullsmeden Amita(Mindy Kaling); gate naskeren Constance(Awkwafina); familiekvinnen Tammy(Sarah Paulson); " +
                "hackeren Nine Ball(Rihanna); og motedesigneren Rose(Helena Bonham Carter)." +
                "Mهlet er diamanter til 150 millioner dollar, som kommer til ه henge rundt halsen pه den verdensberّmte skuespillerinnen Daphne Kluger(Anne Hathaway), som vil vوre midtpunktet pه هrets arrangement, the Met Gala.",
                Image = "~/Content/Pictures/O8.jpg"
            };

            var film14 = new Film
            {
                Title = "Ted",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = "Mّt verdens frekkeste teddybjّrn i denne morsomme komedien, hvor Mark Wahlberg spiller slackeren John Bennett som deler leilighet med kvinnen i sitt liv, Lori (Mila Kunis)" +
                " - og en livs levende kosebamse. Da John var liten, fikk han sitt hّyeste ّnske oppfylt og favorittkosedyret kom til live." +
                " Men i voksen alder er ikke Ted en like sjarmerende kosebjّrn, men snarere en potrّykende, vattfylt alkoholiker som stadig stikker kjepper i hjulene for John.",
                Image = "~/Content/Pictures/Ted.jpg"
            };

            //Horror

            var film15 = new Film
            {
                Title = "IT",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "En liten, sammensveiset vennegjeng tilbringer sommeren 1989 sammen i den lille byen Derry i Maine. De blir stadig mobbet av noen eldre gutter og flere av dem har det ikke bra hjemme. Samtidig plages byen av mystiske og uforklarlige forsvinninger. " +
                "En av de som er bortfّrt er lillebroren til Bill. Bill har en teori om hvor broren kan ha blitt av, og han fهr med seg vennene sine pه leting. " +
                "Etter hvert blir alle i vennegjengen terrorisert av den fryktinngytende klovnen Pennywise, som tar form som ungdommens stّrste frykt. Kun nهr de stهr sammen har de styrke nok til ه overvinne Pennywise.",
                Image = "~/Content/Pictures/IT.jpg"
            };


            var film16 = new Film
            {
                Title = "The Conjuring",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "Basert pه en sann historie forteller <The Conjuring> den grusomme historien om hvordan de verdenskjente paranormale etterforskerne Ed og Lorraine Warren ble tilkalt for ه hjelpe en familie som ble terrorisert av en mّrk tilstedevوrelse pه deres bortgjemte gهrd. " +
                "Tvunget til ه konfrontere en sterk demonisk kraft, finner Ed og Lorraine seg fanget i den mest skremmende opplevelsen i deres liv.",
                Image = "~/Content/Pictures/conjuring.jpg"
            };

            var film17 = new Film
            {
                Title = "The Conjuring 2",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "Ed og Lorraine Warren er velrennomerte paranormale etterforskere pه 1970-tallet." +
                " De fهr i oppdrag ه etterforske et hus bebodd av en familie som har merket et mّrkt nوrvوr. De oppdager at hele omrهdet er hjemsّkt av sataniske spّkelser som fّlger familien hvor de enn gهr." +
                " For ه stoppe denne ondskapen som truer med ه ّdelegge livene til alle involverte, mه Warren-paret ta i bruk all sin kunnskap og spirituelle styrke.",
                Image = "~/Content/Pictures/conjuring2.jpg"
            };


            var film18 = new Film
            {
                Title = "Don't Breathe",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "Tre unge innbruddstyver tar seg inn i huset til en blind mann for ه utfّre det de tror vil vوre et enkelt ran. De kunne ikke ha tatt mer feil. En skummel grّsser fra skaperne av Evil Dead.",
                Image = "~/Content/Pictures/dont.jpg"
            };




            var film19 = new Film
            {
                Title = "Getout",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "Basert pه en sann historie forteller <The Conjuring> den grusomme historien om hvordan de verdenskjente paranormale etterforskerne Ed og Lorraine Warren ble tilkalt for ه hjelpe en familie som ble terrorisert av en mّrk tilstedevوrelse pه deres bortgjemte gهrd. " +
           "Tvunget til ه konfrontere en sterk demonisk kraft, finner Ed og Lorraine seg fanget i den mest skremmende opplevelsen i deres liv.",
                Image = "~/Content/Pictures/conjuring.jpg"
            };

            var film20 = new Film
            {
                Title = "The Conjuring 2",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "إrets store grّssersuksess, Get out, har tatt kritikere og kinopublikum med storm i USA. Den unge fotografen Chris Washington inviteres hjem til kjوrestens familie for en langweekend pه landet. " +
                "Han er bekymret for at de ikke vil like ham fordi han er afroamerikansk, men kjوresten, Rose, beroliger ham med at han har ingenting ه frykte. " +
                "Vel framme fهr han snart bange anelser." +
                " Innbyggerne i nوromrهdet er i overkant interesserte i fه vite alt om ham, og alle tjenerne pه godset oppfّrer seg som passive, smilende zombier." +
                " Er det bare noe Chris innbiller seg, eller foregهr det noe skremmende under den rolige, smهborgerlige fasaden.",
                Image = "~/Content/Pictures/getout.jpg"
            };


            var film21 = new Film
            {
                Title = "Saw",
                Catrgory = "Horror",
                Pris = 150,
                Discription = "Fastbundet med kjetting, i hver sin ende av et nedslitt offentlig toalett, vهkner to menn sakte opp fra sin bevisstlّse tilstand. " +
                "Mellom dem ligger en mann som har skutt seg selv i hodet. Blodet flyter rundt ham, pistolen har han enda i hهnden. Mennene er Dr. Lawrence Gordon og den unge fotografen Adam." +
                "Sjokkerte og desperate innser de at de er blitt ofre for Puslespill - morderen, en psykopat kjent for ه konstruere intrikate situasjoner som skal fه ofrene til ه ta livet av seg selv - eller hverandre. " +
                "Fastbundet med kjetting, i hver sin ende av et nedslitt offentlig toalett, vهkner to menn sakte opp fra sin bevisstlّse tilstand.Mellom dem ligger en mann som har skutt seg selv i hodet. " +
                "Blodet flyter rundt ham, pistolen har han enda i hهnden.Mennene er Dr.Lawrence Gordon og den unge fotografen Adam. " +
                "Sjokkerte og desperate innser de at de er blitt ofre for Puslespill-morderen, en psykopat kjent for ه konstruere intrikate situasjoner som skal fه ofrene til ه ta livet av seg selv - eller hverandre.",
                Image = "~/Content/Pictures/saw.jpg"
            };

            //Action:
            context.Film.Add(film1);
            context.Film.Add(film2);
            context.Film.Add(film3);
            context.Film.Add(film4);
            context.Film.Add(film5);
            context.Film.Add(film6);
            context.Film.Add(film7);

            //Komediet:
            context.Film.Add(film8);
            context.Film.Add(film9);
            context.Film.Add(film10);
            context.Film.Add(film11);
            context.Film.Add(film12);
            context.Film.Add(film13);
            context.Film.Add(film14);

            //Horror:

            context.Film.Add(film15);
            context.Film.Add(film16);
            context.Film.Add(film17);
            context.Film.Add(film18);
            context.Film.Add(film19);
            context.Film.Add(film20);
            context.Film.Add(film21);

            context.Poststed.Add(adrisse);




            //context.Kunde.Add(admin);

            base.Seed(context);


        }
    }
}
