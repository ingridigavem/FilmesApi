using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos {
    public class CreateFilmeDto {
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatório.")]
        public string Diretor { get; set; }

        [StringLength(50, ErrorMessage = "O gênero não pode passar de 50 caracteres.")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 600 minutos.")]
        public int Duracao { get; set; }
    }
}
