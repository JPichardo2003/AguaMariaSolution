using AguaMariaSolutionsDoNet8.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AguaMariaSolutionsDoNet8.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<RecordLavadoraBotellones> RecordLavadoraBotellones { get; set; }
        public DbSet<ControlCalidadProductoTerminado> ControlCalidadProductoTerminado { get; set; }
        public DbSet<ProductoTerminadosDetalle> ProductoTerminadosDetalle { get; set; }
        public DbSet<ControlCalidadAgua> ControlCalidadAgua { get; set; }
        public DbSet<ControlCalidadAguaDetalle> ControlCalidadAguaDetalle { get; set; }
        public DbSet<EntidadesMuestreoAguas> EntidadesMuestreoAguas { get; set; }
        public DbSet<ParametrosEntidadesMuestreoAguas> ParametrosEntidadesMuestreoAguas { get; set; }
        public DbSet<Referencias> Referencias { get; set; }
        public DbSet<ParametrosCreados> ParametrosCreados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Parametros>().HasData(new List<Parametros>()
            {
                //ControlCalidadProductoTerminado
            new Parametros() {ParametroId = 1, Descripci�n = "Cloruro", M�nimo = 0, M�ximo = 250},
            new Parametros() {ParametroId = 2, Descripci�n = "Cloro Residual", M�nimo = 0, M�ximo = 0},
            new Parametros() {ParametroId = 3, Descripci�n = "STD", M�nimo = 0, M�ximo = 500},
            new Parametros() {ParametroId = 4, Descripci�n = "Conductancia", M�nimo = 0, M�ximo = 700},
            new Parametros() {ParametroId = 5, Descripci�n = "Dureza", M�nimo = 0, M�ximo = 500},
            new Parametros() {ParametroId = 6, Descripci�n = "PH", M�nimo = 6.5f, M�ximo = 8.5f},
            new Parametros() {ParametroId = 7, Descripci�n = "Sulfato", M�nimo = 0, M�ximo = 250},
            new Parametros() {ParametroId = 8, Descripci�n = "Nitrato", M�nimo = 0, M�ximo = 10},
            new Parametros() {ParametroId = 9, Descripci�n = "Hierro", M�nimo = 0, M�ximo = 0.3f},
            new Parametros() {ParametroId = 10, Descripci�n = "Color", M�nimo = 0, M�ximo = 5},
            new Parametros() {ParametroId = 11, Descripci�n = "Turbidez", M�nimo = 0, M�ximo = 0.5f},
            new Parametros() {ParametroId = 12, Descripci�n = "Sabor", M�nimo = 1, M�ximo = 1},
            new Parametros() {ParametroId = 13, Descripci�n = "Ozono", M�nimo = 0.05f, M�ximo = 0.1f},
            new Parametros() {ParametroId = 14, Descripci�n = "Lamp UV", M�nimo = 1, M�ximo = 1},

                //Entidades de Cisternar e INAPA - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 120, Descripci�n = "Cloro Residual", M�nimo = 1, M�ximo = 1.5f},
            new Parametros() {ParametroId = 121, Descripci�n = "Dureza", M�nimo = 68.4f, M�ximo = 500},
            new Parametros() {ParametroId = 122, Descripci�n = "STD", M�nimo = 70, M�ximo = 1000},
            new Parametros() {ParametroId = 123, Descripci�n = "Color", M�nimo = 5, M�ximo = 15},
            new Parametros() {ParametroId = 124, Descripci�n = "Turbidez", M�nimo = 10, M�ximo = 25},
            new Parametros() {ParametroId = 125, Descripci�n = "Sulfato", M�nimo = 250, M�ximo = 400},
            new Parametros() {ParametroId = 126, Descripci�n = "Nitrato", M�nimo = 10, M�ximo = 50},

                //Entidad Filtro Carbon Activado - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 130, Descripci�n = "Cloro Residual", M�nimo = 0, M�ximo = 0.05f},
            new Parametros() {ParametroId = 133, Descripci�n = "Olor", M�nimo = 1, M�ximo = 1},

                //Entidad Ablandadores - Registro Control Calidad Del Proceso Del Agua 

                //Entidad Osmosis - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 151, Descripci�n = "STD", M�nimo = 2, M�ximo = 500},});

            modelBuilder.Entity<EntidadesMuestreoAguas>().HasData(new List<EntidadesMuestreoAguas>()
            {
                //Entidades de muestreo de agua
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 1, Descripci�n = "Cisterna 1"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 2, Descripci�n = "Cisterna 2"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 3, Descripci�n = "Cisterna 3"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 4, Descripci�n = "INAPA"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 5, Descripci�n = "Filtro Carb�n Activado"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 6, Descripci�n = "Ablandadores"},
            new EntidadesMuestreoAguas() {EntidadesMuestreoAguaId = 7, Descripci�n = "�smosis"},
            });

            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                //Entidades de muestreo de agua
            new Productos() {ProductoId = 1, Nombre = "Botella de Agua"},
            new Productos() {ProductoId = 2, Nombre = "5 Galones de Agua"},
            new Productos() {ProductoId = 3, Nombre = "1 Galon de Agua"},
            new Productos() {ProductoId = 4, Nombre = "Litro y Medio de Agua"},});

            modelBuilder.Entity<ParametrosEntidadesMuestreoAguas>().HasData(
                new ParametrosEntidadesMuestreoAguas { Id = 1, ParametroId = 120, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 2, ParametroId = 121, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 3, ParametroId = 122, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 4, ParametroId = 123, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 5, ParametroId = 124, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 6, ParametroId = 125, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 7, ParametroId = 126, EntidadesMuestreoAguaId = 1 },
                new ParametrosEntidadesMuestreoAguas { Id = 8, ParametroId = 6, EntidadesMuestreoAguaId = 1 },

                new ParametrosEntidadesMuestreoAguas { Id = 9, ParametroId = 120, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 10, ParametroId = 121, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 11, ParametroId = 122, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 12, ParametroId = 123, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 13, ParametroId = 124, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 14, ParametroId = 125, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 15, ParametroId = 126, EntidadesMuestreoAguaId = 2 },
                new ParametrosEntidadesMuestreoAguas { Id = 16, ParametroId = 6, EntidadesMuestreoAguaId = 2 },

                new ParametrosEntidadesMuestreoAguas { Id = 17, ParametroId = 120, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 18, ParametroId = 121, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 19, ParametroId = 122, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 20, ParametroId = 123, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 21, ParametroId = 124, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 22, ParametroId = 125, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 23, ParametroId = 126, EntidadesMuestreoAguaId = 3 },
                new ParametrosEntidadesMuestreoAguas { Id = 24, ParametroId = 6, EntidadesMuestreoAguaId = 3 },

                new ParametrosEntidadesMuestreoAguas { Id = 25, ParametroId = 120, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 26, ParametroId = 121, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 27, ParametroId = 122, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 29, ParametroId = 123, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 30, ParametroId = 124, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 31, ParametroId = 125, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 32, ParametroId = 126, EntidadesMuestreoAguaId = 4 },
                new ParametrosEntidadesMuestreoAguas { Id = 33, ParametroId = 6, EntidadesMuestreoAguaId = 4 },

                new ParametrosEntidadesMuestreoAguas { Id = 34, ParametroId = 130, EntidadesMuestreoAguaId = 5 },
                new ParametrosEntidadesMuestreoAguas { Id = 35, ParametroId = 123, EntidadesMuestreoAguaId = 5 },
                new ParametrosEntidadesMuestreoAguas { Id = 36, ParametroId = 124, EntidadesMuestreoAguaId = 5 },
                new ParametrosEntidadesMuestreoAguas { Id = 37, ParametroId = 133, EntidadesMuestreoAguaId = 5 },

                new ParametrosEntidadesMuestreoAguas { Id = 38, ParametroId = 5, EntidadesMuestreoAguaId = 6 },
                new ParametrosEntidadesMuestreoAguas { Id = 39, ParametroId = 122, EntidadesMuestreoAguaId = 6 },
                new ParametrosEntidadesMuestreoAguas { Id = 40, ParametroId = 6, EntidadesMuestreoAguaId = 6 },

                new ParametrosEntidadesMuestreoAguas { Id = 41, ParametroId = 6, EntidadesMuestreoAguaId = 7 },
                new ParametrosEntidadesMuestreoAguas { Id = 42, ParametroId = 151, EntidadesMuestreoAguaId = 7 }
            );

            modelBuilder.Entity<Referencias>().HasData(
                new Referencias { ReferenciaId = 1, ParametroId = 1, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 2, ParametroId = 2, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 3, ParametroId = 3, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 4, ParametroId = 5, Descripci�n = "CaCo3" },
                new Referencias { ReferenciaId = 5, ParametroId = 7, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 6, ParametroId = 8, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 7, ParametroId = 9, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 8, ParametroId = 10, Descripci�n = "UNID" },
                new Referencias { ReferenciaId = 9, ParametroId = 11, Descripci�n = "NTU" },
                new Referencias { ReferenciaId = 10, ParametroId = 12, Descripci�n = "(1) Insipido y (0) Sapido" },
                new Referencias { ReferenciaId = 11, ParametroId = 13, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 12, ParametroId = 14, Descripci�n = "(1) S� y (0) no" },
                new Referencias { ReferenciaId = 13, ParametroId = 120, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 14, ParametroId = 121, Descripci�n = "CaCo3" },
                new Referencias { ReferenciaId = 15, ParametroId = 122, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 16, ParametroId = 123, Descripci�n = "U. Pt-Co" },
                new Referencias { ReferenciaId = 17, ParametroId = 124, Descripci�n = "FTU" },
                new Referencias { ReferenciaId = 18, ParametroId = 125, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 19, ParametroId = 126, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 20, ParametroId = 130, Descripci�n = "mg/L" },
                new Referencias { ReferenciaId = 21, ParametroId = 133, Descripci�n = "(1) Inodoro y (0) Odoro" },
                new Referencias { ReferenciaId = 22, ParametroId = 151, Descripci�n = "mg/L" }
            );
        }
    }
}
