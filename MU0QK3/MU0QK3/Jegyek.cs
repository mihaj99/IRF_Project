//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MU0QK3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jegyek
    {
        public int Id { get; set; }
        public Nullable<int> TanuloFK { get; set; }
        public Nullable<int> Jegy { get; set; }
        public Nullable<System.DateTime> Dátum { get; set; }
        public string Mire { get; set; }
    
        public virtual Tanulok Tanulok { get; set; }
    }
}