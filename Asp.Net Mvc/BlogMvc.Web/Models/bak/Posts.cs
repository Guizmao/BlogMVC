//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogMvc.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posts
    {
        public Posts()
        {
            this.Comments = new HashSet<Comments>();
        }
    
        public int Id { get; set; }
        public int Categorie_Id { get; set; }
        public int User_Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Categories Categorie { get; set; }
        public virtual Users User { get; set; }
    }
}