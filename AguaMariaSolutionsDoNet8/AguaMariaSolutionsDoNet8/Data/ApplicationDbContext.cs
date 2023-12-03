using AguaMariaSolutionsDoNet8.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AguaMariaSolutionsDoNet8.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<RecordLavadoraBotellones> RecordLavadoraBotellones { get; set; }
        public DbSet<ControlCalidadProductoTerminado> ControlCalidadProductoTerminado { get; set; }
        public DbSet<ProductoTerminadosDetalle> ProductoTerminadosDetalle { get; set; }
        public DbSet<ControlCalidadAgua> ControlCalidadAgua { get; set; }
        public DbSet<ControlCalidadAguaDetalle> ControlCalidadAguaDetalle { get; set; }

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
            new Parametros() {ParametroId = 20, Descripci�n = "Cloro Residual", M�nimo = 1, M�ximo = 1.5f},
            new Parametros() {ParametroId = 21, Descripci�n = "Dureza", M�nimo = 68.4f, M�ximo = 500},
            new Parametros() {ParametroId = 22, Descripci�n = "STD", M�nimo = 70, M�ximo = 1000},
            new Parametros() {ParametroId = 23, Descripci�n = "Color", M�nimo = 5, M�ximo = 15},
            new Parametros() {ParametroId = 24, Descripci�n = "Turbidez", M�nimo = 10, M�ximo = 25},
            new Parametros() {ParametroId = 25, Descripci�n = "Sulfato", M�nimo = 250, M�ximo = 400},
            new Parametros() {ParametroId = 26, Descripci�n = "Nitrato", M�nimo = 10, M�ximo = 50},
            new Parametros() {ParametroId = 27, Descripci�n = "PH", M�nimo = 6.5f, M�ximo = 8.5f},

                //Entidad Filtro Carbon Activado - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 30, Descripci�n = "Cloro Residual", M�nimo = 0, M�ximo = 0.05f},
            new Parametros() {ParametroId = 31, Descripci�n = "Color", M�nimo = 5, M�ximo = 15},
            new Parametros() {ParametroId = 32, Descripci�n = "Turbidez", M�nimo = 10, M�ximo = 25},
            new Parametros() {ParametroId = 33, Descripci�n = "Olor", M�nimo = 0, M�ximo = 1},

                //Entidad Ablandadores - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 40, Descripci�n = "Dureza", M�nimo = 0, M�ximo = 500},
            new Parametros() {ParametroId = 41, Descripci�n = "STD", M�nimo = 70, M�ximo = 1000},
            new Parametros() {ParametroId = 42, Descripci�n = "PH", M�nimo = 6.5f, M�ximo = 8.5f},

                //Entidad Osmosis - Registro Control Calidad Del Proceso Del Agua 
            new Parametros() {ParametroId = 50, Descripci�n = "PH", M�nimo = 6.5f, M�ximo = 8.5f},
            new Parametros() {ParametroId = 51, Descripci�n = "STD", M�nimo = 2, M�ximo = 500},});

            modelBuilder.Entity<EntidadesMuestreoAgua>().HasData(new List<EntidadesMuestreoAgua>()
            {
                //Entidades de muestreo de agua
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 1, Descripci�n = "Cisterna 1"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 2, Descripci�n = "Cisterna 2"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 3, Descripci�n = "Cisterna 3"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 4, Descripci�n = "INAPA"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 5, Descripci�n = "Filtro Carb�n Activado"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 6, Descripci�n = "Ablandadores"},
            new EntidadesMuestreoAgua() {EntidadesMuestreoAguaId = 7, Descripci�n = "�smosis"},});


            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                //Entidades de muestreo de agua
            new Productos() {ProductoId = 1, Nombre = "Botella de Agua"},
            new Productos() {ProductoId = 2, Nombre = "5 Galones de Agua"},
            new Productos() {ProductoId = 3, Nombre = "1 Galon de Agua"},
            new Productos() {ProductoId = 4, Nombre = "Litro y Medio de Agua"},});
        }

        public DbSet<EntidadesMuestreoAgua> EntidadesMuestreoAgua { get; set; } = default!;
    }
}
