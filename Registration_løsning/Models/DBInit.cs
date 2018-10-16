using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Registration_løsning.Models

{
    public class DBInit : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {



            var film1 = new Film
            {
                Title = "21 Jump Street",
                Catrgory = "Komedie",
                Pris = 150,
                Discription = " 21 Jump Street var en amerikansk kriminalserie som gikk på Fox fra 1987 til 1991. Serien handlet om en gruppe unge politibetjenter ved en politistasjon i USA." +
                "Serien startet 12.april 1987 og holdt på til 27.april 1991 i USA.Det ble sendt totalt 103 episoder(5 sesonger)," +
                "på ca.en time hver.En spinnoff med navn Booker basert på karakteren Dennis Booker ble laget, men varte kun en sesong,fra september 1989 til juni 1990." +
                "Serien ga Johnny Depp(Tom Hanson) en bra start på skuespillerkarrieren, ved å bli et tenåringsidol.Dette irriterte Depp, men han hadde en kontrakt som han ble først løst fra etter den fjerde sesongen, og han forlot da serien sammen med Dustin Nguyen.",
                Image = "~/Content/Pictures/21jump.jpg"
            };

            var film2 = new Film
            {
                Title = "SuperMan",
                Catrgory = "Komedie",
                Pris = 160,
                Discription = " heihief  igdi gfiw ef di wduf wefowe d wdio iwgcf",
                Image = "~/Content/Pictures/IT.jpg"
            };

            var film3 = new Film
            {
                Title = "slange",
                Catrgory = "Action",
                Pris = 150,
                Discription = " Film handelsen er om en gutte som heter waqas som lager klanger mellom fulk  ",
                Image = "~/Content/Pictures/avengers.jpg"
            };

            var film4 = new Film
            {
                Title = "slange",
                Catrgory = "Horror",
                Pris = 150,
                Discription = " Film handelsen er om en gutte som heter waqas som lager klanger mellom fulk  ",
                Image = "~/Content/Pictures/avengers.jpg"
            };


            context.Film.Add(film1);
            context.Film.Add(film2);
            context.Film.Add(film3);
            context.Film.Add(film4);


            base.Seed(context);

        }
    }
}
