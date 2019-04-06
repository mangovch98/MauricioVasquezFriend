using System.ComponentModel.DataAnnotations;

namespace APIparcial.Models
{
    public enum AmiType
    {
        Conocido,
        Compañero_Estudio,
        Colega_de_Trabajo,
        Amigo,
        Amigo_de_Infancia,
        Pariente
    }
    public enum StatusType
    {
        Activo,
        Inactivo
    }


    public class Amigo
    {
        [Key]
        public int AmigoID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Birthday { get; set; }
        [Required]
        public AmiType Ami {get; set;}
        public StatusType Statuts { get; set; }

    }
}