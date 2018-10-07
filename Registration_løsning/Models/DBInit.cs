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
                Title = "harry Potter",
                Catrgory = "barn",
                Pris = 150,
                Discription = " heihief  igdi gfiw ef di wduf wefowe d wdio iwgcf",
                Image= "~Con"
            };

            var film2 = new Film
            {
                Title = "SuperMan",
                Catrgory = "barn",
                Pris = 160,
                Discription = " heihief  igdi gfiw ef di wduf wefowe d wdio iwgcf"
            };

            var film3 = new Film
            {
                Title = "slange",
                Catrgory = "barn",
                Pris =150,
                Discription = " Film handelsen er om en gutte som heter waqas som lager klanger mellom fulk  "
            };


            context.Film.Add(film1);
            context.Film.Add(film2);
            context.Film.Add(film3);

            base.Seed(context);

        }
    }
}
