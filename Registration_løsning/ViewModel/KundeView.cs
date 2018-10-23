﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration_løsning.Models;


namespace Registration_løsning.ViewModel
{
    public class KundeView
    {
        public IEnumerable<Kunde> Kunde { get; set; }
        public IEnumerable<Poststed>Poststed { get; set; }


        public KundeView(Kunde kunde, List<Poststed> poststed)
            {
            Kunde = Kunde;
            Poststed = Poststed;

            }

            public KundeView() { }
            }
            }