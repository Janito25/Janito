Random rand = new Random();
int numRand = rand.Next(5, 11);
int horas = 0;

for (int minutos = 1; minutos <= 60; minutos++)
{

    if (minutos.Equals(60))
    {
        horas++;
        Console.WriteLine("Passou");
        Console.WriteLine("São " + horas + " horas!");
        minutos = 0;

    }

    if (horas.Equals(numRand))
    {
        Console.WriteLine("Passaram " + horas + " horas!");
        break;
    }

}

