// Cristian Josué Medina Galeano - 20251900163
using System;

namespace EjercicioGit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos
            Console.WriteLine("Alumno: Cristian Josué Medina Galeano - 20251900163");

            // Instancias
            BusUrbano miBus = new BusUrbano("BUS-504", 40, 80);
            Taxi miTaxi = new Taxi("TX-COM", 4, 100);
            BicicletaElectrica miBici = new BicicletaElectrica("BICI-01", 1, 30);

            Vehiculo[] flota = { miBus, miTaxi, miBici };

            // Simulación de Viajes (10 Km y luego 30 Km)
            foreach (var v in flota) v.RecorrerKilometros(10);
            foreach (var v in flota) v.RecorrerKilometros(30);

            // Mostrar Resultados
            Console.WriteLine("--- Resultados finales del sistema ---");
            foreach (var v in flota)
            {
                v.MostrarInformacion();
                Console.WriteLine($"Costo Total del Viaje: Lps. {v.CalcularCostoViaje()}\n");
            }
        }
    }
}