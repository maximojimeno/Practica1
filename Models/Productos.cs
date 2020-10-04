using System;
using System.ComponentModel.DataAnnotations;

namespace Practica1.Models
{
    public class Productos
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage="Nombre requerido..."),MaxLength(100)]
        public string nombre { get; set; }  
        [Required(ErrorMessage="La descripcion del producto es requerida..."),MaxLength(200)]
        public string descripcion { get; set; }
        [Required,Range(minimum:1,maximum:int.MaxValue,ErrorMessage = "El costo debe ser minimo 1")]
        public decimal costo { get; set; } = 0;
        [Required,Range(minimum:0,maximum:int.MaxValue,ErrorMessage = "El costo debe ser minimo 1")]
        public decimal precio { get; set; } = 0;
        [Required,Range(minimum:0,maximum:int.MaxValue,ErrorMessage = "El valor de la existencia debe ser minimo 1")]
        public int existencia { get; set; } = 1;
        [Required]
        public  bool estado { get; set; } = true;
        [Required]
        public DateTime fechaCreacion  { get; set; } = DateTime.Now;



    }
}