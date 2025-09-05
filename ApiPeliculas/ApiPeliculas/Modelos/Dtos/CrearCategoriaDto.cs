﻿using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CrearCatergoriaDto
    {
        
        [ Required(ErrorMessage = "El nombre  es  obligatorio")]
        [MaxLength(100,ErrorMessage = "El número máximo de caracteres es  100!")]
        public string Nombre { get; set; }
    
    }
}
