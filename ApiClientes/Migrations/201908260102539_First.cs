namespace ApiClientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EstadoCivil = c.Int(nullable: false),
                        RG = c.Int(nullable: false),
                        CPFCNPJ = c.String(),
                        NomeFantasia = c.String(),
                        Cep = c.String(),
                        Endereço = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
