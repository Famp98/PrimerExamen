using System;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcialAbril.Models
{
    public enum FriendType
    {
        Conocido,
        Compañero,
        Estudio,
        ColegadeTrabajo,
        Amigo,
        AmigodeInfancia,
        Pariente

    }



    public class FabioMurguiaFriend
    {
        [Key]
        public int FriendId { get; set; }

        [Required]
        [Display(Name="Nombre completo")]
        public string Name  { get; set; }

        [Required]
        [Display(Name="Tipo")]
        public FriendType Type { get; set; }
        [Display(Name="Apodo")]
        public string Nickname { get; set; }
        [Display(Name = "Cumpleaños")]
        public DateTime BirthDdate { get; set; }

    }
}