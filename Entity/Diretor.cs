using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("tab_diretor")]
    class Diretor

    {
        [Key]
        public int Cod_diretor { get; set; }
        [Required]
        public string Nome_diretor { get; set; }

        //FK
        public virtual ICollection<Filme> Filmes { get; set; }

        public Diretor()
        {
            this.Filmes = new List<Filme>();
        }

        public Diretor(string nome_diretor)
        {
            this.Nome_diretor = nome_diretor;
            this.Filmes = new List<Filme>();
        }

        public override string ToString()
        {
            return this.Cod_diretor + " - " + this.Nome_diretor;
        }


    }
}