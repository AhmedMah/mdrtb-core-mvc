﻿using EtbSomalia.Models;
using System;
using System.Collections.Generic;

namespace EtbSomalia.ViewModel
{
    public class InventoryIndexViewModel
    {
        public DateTime Date1x { get; set; }
        public DateTime Date2x { get; set; }
        public List<Drug> InventoryDrugs { get; set; }

        public InventoryIndexViewModel() {
            Date1x = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Date2x = Date1x.AddMonths(1).AddDays(-1);
            InventoryDrugs = new List<Drug>();



        }


    }
}
