namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Registro = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 1200, unicode: false),
                        Isbn = c.String(nullable: false, maxLength: 15, unicode: false),
                        Genero = c.Int(nullable: false),
                        Editora = c.Int(nullable: false),
                        Sinopse = c.String(),
                        Observacoes = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                        Usuarios_Id = c.Int(),
                        Usuarios_Id1 = c.Int(),
                        Editoras_Id = c.Int(),
                        Generos_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id1)
                .ForeignKey("dbo.Editoras", t => t.Editoras_Id)
                .ForeignKey("dbo.Generos", t => t.Generos_Id)
                .Index(t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id1)
                .Index(t => t.Editoras_Id)
                .Index(t => t.Generos_Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Livro = c.Int(nullable: false),
                        Usuario = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Devolucao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuAlt)
                .ForeignKey("dbo.Usuarios", t => t.Usuario)
                .ForeignKey("dbo.Usuarios", t => t.UsuInc)
                .ForeignKey("dbo.Livros", t => t.Livro)
                .Index(t => t.Livro)
                .Index(t => t.Usuario)
                .Index(t => t.UsuInc)
                .Index(t => t.UsuAlt);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroAutor",
                c => new
                    {
                        Autor = c.Int(nullable: false),
                        Livro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Autor, t.Livro })
                .ForeignKey("dbo.Autores", t => t.Autor, cascadeDelete: true)
                .ForeignKey("dbo.Livros", t => t.Livro, cascadeDelete: true)
                .Index(t => t.Autor)
                .Index(t => t.Livro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras");
            DropForeignKey("dbo.LivroAutor", "Livro", "dbo.Livros");
            DropForeignKey("dbo.LivroAutor", "Autor", "dbo.Autores");
            DropForeignKey("dbo.Locacao", "Livro", "dbo.Livros");
            DropForeignKey("dbo.Locacao", "UsuInc", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "Usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "UsuAlt", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios");
            DropIndex("dbo.LivroAutor", new[] { "Livro" });
            DropIndex("dbo.LivroAutor", new[] { "Autor" });
            DropIndex("dbo.Locacao", new[] { "UsuAlt" });
            DropIndex("dbo.Locacao", new[] { "UsuInc" });
            DropIndex("dbo.Locacao", new[] { "Usuario" });
            DropIndex("dbo.Locacao", new[] { "Livro" });
            DropIndex("dbo.Livros", new[] { "Generos_Id" });
            DropIndex("dbo.Livros", new[] { "Editoras_Id" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id1" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id" });
            DropTable("dbo.LivroAutor");
            DropTable("dbo.Generos");
            DropTable("dbo.Editoras");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacao");
            DropTable("dbo.Livros");
            DropTable("dbo.Autores");
        }
    }
}
