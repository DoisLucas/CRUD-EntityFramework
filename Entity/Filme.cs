using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("tab_filme")]
    class Filme
    {

        [Key]
        public int Cod_filme { get; set; }
        [Required]
        public string Nome_filme { get; set; }
        [Required]
        public DateTime Data { get; set; }

        //FK
        public Categoria Categoria { get; set; }

        //FK
        public virtual ICollection<Diretor> Diretor { get; set; }


        public Filme()
        {
            this.Diretor = new List<Diretor>();
        }

        public Filme(string nome_filme, DateTime data, Categoria c)
        {
            this.Nome_filme = nome_filme;
            this.Data = data;
            this.Categoria = c;
            this.Diretor = new List<Diretor>();
        }

        public override string ToString()
        {
            return this.Cod_filme + " - " + this.Nome_filme + " - " + this.Data.ToString() + this.Categoria.ToString();
        }

    }
}
