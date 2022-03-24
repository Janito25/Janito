
string[] listaPalavras = new string[] {"addition", "fail", "zone", "isolation", "poison", "cutting", "court", "attitude", "bronze"};

foreach(var palavra in listaPalavras)
    Console.WriteLine(palavra);

Console.WriteLine("Qual o tema que deseja pesquisar?");
string tema = Console.ReadLine();


void ordenarPalavras(string[] listaPalavras, string tema) {
    StringComparer ordenar = StringComparer.CurrentCultureIgnoreCase;

    Array.Sort(listaPalavras, ordenar);

    Console.WriteLine();
    Console.WriteLine("Ordem alfabética:");

    for (int i = 0; i < listaPalavras.Length; i++)
    {
        Console.WriteLine(listaPalavras[i]);
    }


}

