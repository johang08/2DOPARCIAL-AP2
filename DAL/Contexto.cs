using System;
using 2doParcial.Models

namespace 2do
public class 2doParcial
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
protected override void OnModelCreating(ModelBuilder modelBuilder)

{

    modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "FERRETERIA GAMA" });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 09, 01), ClienteId = 1, Monto = 1000, Balance = 1000 });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 10, 01), ClienteId = 1, Monto = 900, Balance = 800 });



    modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "AVALON DISCO" });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 09, 01), ClienteId = 2, Monto = 2000, Balance = 2000 });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 10, 01), ClienteId = 2, Monto = 1900, Balance = 1800 });



    modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "PRESTAMOS CEFIPROD" });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 09, 01), ClienteId = 3, Monto = 3000, Balance = 3000 });

    modelBuilder.Entity<Ventas>().HasData(new Ventas() { Fecha = new DateTime(2020, 10, 01), ClienteId = 3, Monto = 2900, Balance = 1900 });

}