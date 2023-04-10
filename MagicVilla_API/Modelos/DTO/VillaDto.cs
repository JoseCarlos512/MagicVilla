using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.DTO
{
    public class VillaDto
    {
        public int Id { get; set; }


        /** .net core **/
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public int Ocupantes{ get; set; }
        public int MetrosCuadrados{ get; set; }
    }
}
