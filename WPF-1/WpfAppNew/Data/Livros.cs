namespace WpfAppNew.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Livros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livros()
        {
            Locacao = new HashSet<Locacao>();
            Autores = new HashSet<Autores>();
        }

        public int Id { get; set; }

        public int Registro { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(15)]
        public string Isbn { get; set; }

        public int Genero { get; set; }

        public int Editora { get; set; }

        public string Sinopse { get; set; }

        [StringLength(1000)]
        public string Observações { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DataInc { get; set; }

        public DateTime DataAlt { get; set; }

        public virtual Editora Editora1 { get; set; }

        public virtual Genero Genero1 { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Usuarios Usuarios1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacao> Locacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autores> Autores { get; set; }
    }
}
