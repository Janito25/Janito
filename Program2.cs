namespace HttpClientStatus;

class Program
{
    static async Task Main(string[] args)
    {
        List<string> list = new List<string>();
        using var client = new HttpClient();

        var result = await client.GetAsync("https://random-word-api.herokuapp.com/word?number=10");
        //Console.WriteLine(result.StatusCode);

        string content = await client.GetStringAsync("https://random-word-api.herokuapp.com/word?number=10");

        string[] tmp = content.Split('[', ',', ']');

        foreach (var line in tmp)
        {
            if (line != "")
                list.Add(line);
        }

        Console.WriteLine("A lista ordenada por ordem alfabética é a seguinte: ");
        ordenarLista(list);
    }

    static void ordenarLista(List<string> lista)
    {
        IEnumerable<string> query = from word in lista
                                    orderby word ascending
                                    select word;

        foreach (string str in query)
            Console.WriteLine(str);
    
    }
}