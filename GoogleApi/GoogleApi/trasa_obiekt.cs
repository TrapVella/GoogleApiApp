//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoogleApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class trasa_obiekt
    {
        public int id { get; set; }
        public Nullable<int> id_trasa { get; set; }
        public Nullable<int> id_obiekt { get; set; }
        public Nullable<int> kolejnosc { get; set; }
    
        public virtual obiekty obiekty { get; set; }
        public virtual trasa_naglowek trasa_naglowek { get; set; }
    }
}
