namespace LoteAutosGit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        idauto = c.Int(nullable: false, identity: true),
                        marca = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        modelo = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        nserie = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        precio = c.Double(nullable: false),
                        color = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        nacionalidad = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        Observacion = c.String(maxLength: 64, storeType: "nvarchar"),
                        propietarios_idpropietario = c.Int(),
                    })
                .PrimaryKey(t => t.idauto)
                .ForeignKey("dbo.Propietarios", t => t.propietarios_idpropietario)
                .Index(t => t.propietarios_idpropietario);
            
            CreateTable(
                "dbo.Galerias",
                c => new
                    {
                        idgaleria = c.Int(nullable: false, identity: true),
                        fotografia = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        status = c.Boolean(nullable: false),
                        autos_idauto = c.Int(),
                    })
                .PrimaryKey(t => t.idgaleria)
                .ForeignKey("dbo.Autos", t => t.autos_idauto)
                .Index(t => t.autos_idauto);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        idpago = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        status = c.Boolean(nullable: false),
                        autos_idauto = c.Int(),
                        propietarios_idpropietario = c.Int(),
                    })
                .PrimaryKey(t => t.idpago)
                .ForeignKey("dbo.Autos", t => t.autos_idauto)
                .ForeignKey("dbo.Propietarios", t => t.propietarios_idpropietario)
                .Index(t => t.autos_idauto)
                .Index(t => t.propietarios_idpropietario);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        idpropietario = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        appaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        apmaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        calle = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        colonia = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ncasa = c.String(nullable: false, maxLength: 8, storeType: "nvarchar"),
                        avenida = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ciudad = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        pais = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        telefono = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        correo = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ine = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        fotografia = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idpropietario);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        idventa = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        status = c.Boolean(nullable: false),
                        autos_idauto = c.Int(),
                        compradores_idcomprador = c.Int(),
                        usuarios_idusuario = c.Int(),
                    })
                .PrimaryKey(t => t.idventa)
                .ForeignKey("dbo.Autos", t => t.autos_idauto)
                .ForeignKey("dbo.Compradores", t => t.compradores_idcomprador)
                .ForeignKey("dbo.Usuarios", t => t.usuarios_idusuario)
                .Index(t => t.autos_idauto)
                .Index(t => t.compradores_idcomprador)
                .Index(t => t.usuarios_idusuario);
            
            CreateTable(
                "dbo.Compradores",
                c => new
                    {
                        idcomprador = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        appaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        apmaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        calle = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        colonia = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ncasa = c.String(nullable: false, maxLength: 8, storeType: "nvarchar"),
                        avenida = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ciudad = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        pais = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idcomprador);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idusuario = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        appaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        apmaterno = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        calle = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        colonia = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ncasa = c.String(nullable: false, maxLength: 8, storeType: "nvarchar"),
                        avenida = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        ciudad = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        pais = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        email = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        nickname = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        password = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        niveles_idnivel = c.Int(),
                    })
                .PrimaryKey(t => t.idusuario)
                .ForeignKey("dbo.Niveles", t => t.niveles_idnivel)
                .Index(t => t.niveles_idnivel);
            
            CreateTable(
                "dbo.Niveles",
                c => new
                    {
                        idnivel = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        status = c.Boolean(nullable: false),
                        descripcion = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idnivel);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        idpermisonegadonivel = c.Int(nullable: false, identity: true),
                        status = c.Boolean(nullable: false),
                        niveles_idnivel = c.Int(),
                        permisos_idpermiso = c.Int(),
                    })
                .PrimaryKey(t => t.idpermisonegadonivel)
                .ForeignKey("dbo.Niveles", t => t.niveles_idnivel)
                .ForeignKey("dbo.Permisos", t => t.permisos_idpermiso)
                .Index(t => t.niveles_idnivel)
                .Index(t => t.permisos_idpermiso);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        idpermiso = c.Int(nullable: false, identity: true),
                        modulo = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                        descripcion = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idpermiso);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "usuarios_idusuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "niveles_idnivel", "dbo.Niveles");
            DropForeignKey("dbo.PermisosNegados", "permisos_idpermiso", "dbo.Permisos");
            DropForeignKey("dbo.PermisosNegados", "niveles_idnivel", "dbo.Niveles");
            DropForeignKey("dbo.Ventas", "compradores_idcomprador", "dbo.Compradores");
            DropForeignKey("dbo.Ventas", "autos_idauto", "dbo.Autos");
            DropForeignKey("dbo.Pagos", "propietarios_idpropietario", "dbo.Propietarios");
            DropForeignKey("dbo.Autos", "propietarios_idpropietario", "dbo.Propietarios");
            DropForeignKey("dbo.Pagos", "autos_idauto", "dbo.Autos");
            DropForeignKey("dbo.Galerias", "autos_idauto", "dbo.Autos");
            DropIndex("dbo.PermisosNegados", new[] { "permisos_idpermiso" });
            DropIndex("dbo.PermisosNegados", new[] { "niveles_idnivel" });
            DropIndex("dbo.Usuarios", new[] { "niveles_idnivel" });
            DropIndex("dbo.Ventas", new[] { "usuarios_idusuario" });
            DropIndex("dbo.Ventas", new[] { "compradores_idcomprador" });
            DropIndex("dbo.Ventas", new[] { "autos_idauto" });
            DropIndex("dbo.Pagos", new[] { "propietarios_idpropietario" });
            DropIndex("dbo.Pagos", new[] { "autos_idauto" });
            DropIndex("dbo.Galerias", new[] { "autos_idauto" });
            DropIndex("dbo.Autos", new[] { "propietarios_idpropietario" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Niveles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Compradores");
            DropTable("dbo.Ventas");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Pagos");
            DropTable("dbo.Galerias");
            DropTable("dbo.Autos");
        }
    }
}
