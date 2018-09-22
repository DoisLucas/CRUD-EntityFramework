using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("tab_categoria")]
    class Categoria
    {
        [Key]
        public int Cod_categoria { get; set; }
        [Required]
        public string Desc_categoria { get; set; }

        //FK
        public ICollection<Filme> filmes { get; set; }

        public Categoria()
        {
            this.filmes = new List<Filme>();
        }

        public Categoria(string desc_categoria)
        {
            this.Desc_categoria = desc_categoria;
            this.filmes = new List<Filme>();
        }

        public override string ToString()
        {
            return this.Cod_categoria + " - " + this.Desc_categoria;
        }


    }
}
