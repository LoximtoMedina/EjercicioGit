// Cristian Josué Medina Galeano - 20251900163
using System;

namespace EjercicioGit
{
    // Clase Padre Abstracta
    public abstract class Vehiculo
    {
        private string placa;
        private int capacidadPasajeros;
        private double velocidadMaxima;
        private double kmRecorridos;

        public string Placa { get => placa; set => placa = value; }
        public double KmRecorridos { get => kmRecorridos; set => kmRecorridos = value; }

        public Vehiculo(string placa, int capacidad, double velocidad)
        {
            Placa = placa;
            capacidadPasajeros = capacidad;
            velocidadMaxima = velocidad;
            KmRecorridos = 0;
        }

        public void RecorrerKilometros(double kms) => KmRecorridos += kms;

        public abstract double CalcularCostoViaje();
        public abstract void MostrarInformacion();
    }

    // Clases Hijas
    public class BusUrbano : Vehiculo
    {
        public double TarifaPorKm = 10.50;
        public BusUrbano(string p, int c, double v) : base(p, c, v) { }
        public override double CalcularCostoViaje() => KmRecorridos * TarifaPorKm;
        public override void MostrarInformacion() => Console.WriteLine($"Bus - Placa: {Placa}, Total Km: {KmRecorridos}");
    }

    public class Taxi : Vehiculo
    {
        public double TarifaBase = 50.00;
        public double TarifaPorKm = 12.00;
        public Taxi(string p, int c, double v) : base(p, c, v) { }
        public override double CalcularCostoViaje() => TarifaBase + (KmRecorridos * TarifaPorKm);
        public override void MostrarInformacion() => Console.WriteLine($"Taxi - Placa: {Placa}, Total Km: {KmRecorridos}");
    }

    public class BicicletaElectrica : Vehiculo
    {
        public double CostoEnergiaPorKm = 2.50;
        public BicicletaElectrica(string p, int c, double v) : base(p, c, v) { }
        public override double CalcularCostoViaje() => KmRecorridos * CostoEnergiaPorKm;
        public override void MostrarInformacion() => Console.WriteLine($"Bici Eléctrica - Placa: {Placa}, Total Km: {KmRecorridos}");
    }
}