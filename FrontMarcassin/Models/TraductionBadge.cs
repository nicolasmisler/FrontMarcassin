//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontMarcassin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TraductionBadge
    {
        public int idBadge { get; set; }
        public int idLanguage { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
    
        public virtual Badge Badge { get; set; }
        public virtual Language Language { get; set; }
    }
}
