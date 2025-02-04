using System;

class CochinitaFeliz
{
    private int totalTacos = 0;
    private int totalTortas = 0;

    public void RegistraVenta(int tacos, int tortas)
    {
        totalTacos += tacos;
        totalTortas += tortas;
    }

    public int CuantosTacos()
    {
        return totalTacos;
    }

    public int CuantasTortas()
    {
        return totalTortas;
    }

    public bool VenderTripleDeTacos()
    {
        return totalTacos > (3 * totalTortas);
    }
}

class Program
{
    static void Main()
    {
        CochinitaFeliz puesto = new CochinitaFeliz();
        int opcion;

        do
        {
            Console.WriteLine("Ingrese la cantidad de tacos vendidos:");
            int tacos = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Ingrese la cantidad de tortas vendidas:");
            string tortasInput = Console.ReadLine() ?? string.Empty;
            int tortas = string.IsNullOrEmpty(tortasInput) ? 0 : int.Parse(tortasInput);

            puesto.RegistraVenta(tacos, tortas);

            Console.WriteLine("¿Desea registrar otra venta? (1 = Sí, 2 = No):");
            opcion = int.Parse(Console.ReadLine() ?? "0");
        } while (opcion == 1);

        Console.WriteLine("Resumen de ventas:");
        Console.WriteLine("Total de tacos vendidos: " + puesto.CuantosTacos());
        Console.WriteLine("Total de tortas vendidas: " + puesto.CuantasTortas());

        if (puesto.VenderTripleDeTacos())
        {
            Console.WriteLine("Se vendieron más de 3 veces la cantidad de tacos que de tortas.");
        }
        else
        {
            Console.WriteLine(
                "No se superó el triple de tacos vendidos en comparación con las tortas."
            );
        }
    }
}
