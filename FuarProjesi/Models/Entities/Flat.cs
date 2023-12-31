﻿namespace FuarProjesi.Models.Entities
{
    public class Flat : BaseEntity
    {
        public int FlatPrice { get; set; }
        public string FlatNo { get; set; }
        public string FloorNo { get; set; }
        public int MSquare { get; set; }
        public int FlatPopulation { get; set; }
        public int PlaceID { get; set; }

        //Relational Properties
        public virtual Place Place { get; set; }
    }
}
