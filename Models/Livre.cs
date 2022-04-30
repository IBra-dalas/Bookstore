using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace NewResto.Models
{
    [Table("Livre")]
    public class Livre
    {
        [Key]
        public int IdLivre { get; set; }

        [Display(Name = "Date Parition :")]
        public DateTime DateParition { get; set; }

        public string TitreLivre { get; set; }
        //  [ForeignKey("IdAuteur")]
        [DisplayName("Auteur :")]
        public virtual Auteur UnAuteur { get; set; }

        public IEnumerable<Auteur> AuteurOptionType = new List<Auteur>
        {
            new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
            new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
            new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
        };



        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    //if(string.IsNullOrWhiteSpace(TitreLivre)) yield return new ValidationResult("Veillez entrer le titre et la date de parition", new [] { "" }){ }
        //}


    }

    internal class AuMoinsDeuxDesAttributAttribute : Attribute
    {
    }
}
