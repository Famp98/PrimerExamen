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
        public string Name  { get; set; }

        [Required]
        public FriendType Type { get; set; }

        public string Nickname { get; set; }
        public DateTime BirthDdate { get; set; }

    }
}