using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "O título deve ter entre 2 e 30 caracteres.")]
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string? Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O genro deve ter entre 3 e 20 caracteres.")]
        [Required(ErrorMessage = "O  gênero é obrigatório.")]
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string? Rating {  get; set; }
    }
}