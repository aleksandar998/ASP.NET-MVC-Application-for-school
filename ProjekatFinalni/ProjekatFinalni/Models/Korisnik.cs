//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatFinalni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Korisnik
    {

        public int KorisnikID { get; set; }
        [Required(ErrorMessage = "Morate uneti korisnicko ime.")]
        [DisplayName("Korisnicko ime:")]

        public string Korisnickoime { get; set; }

        [Required(ErrorMessage = "Morate uneti lozinku.")]
        [DisplayName("Lozinka:")]

        [DataType(DataType.Password)]

        public string Lozinka { get; set; }

        [Required(ErrorMessage = "Morate potvrditi lozinku.")]
        [DisplayName("Potvrdi lozinku:")]

        [DataType(DataType.Password)]
        [Compare("Lozinka", ErrorMessage = "Lozinke se ne poklapaju")]
        public string PotvrdiLozinku { get; set; }

        [DisplayName("Admin:")]
        public bool DaLiJeAdmin { get; set; }

        [DisplayName("Gost:")]
        public bool Gost { get; set; }

        [DisplayName("Unos:")]
        public bool PravoUnosa { get; set; }

        public string LoginErrorPoruka { get; set; }
    }
}
