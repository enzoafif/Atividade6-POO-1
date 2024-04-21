class Impressora
{
    Documento _documento;
    int _quantidadeCopias;

    public Impressora(Documento documento)
    {
        _documento = documento;
        _quantidadeCopias = 1;
    }

    
    public void Imprimir()
    {
        for (int i = 0; i < _quantidadeCopias; i++)
        {
            Console.WriteLine(_documento.Texto);
        }
    }

    
    public void SolicitarTexto()
    {
        Console.Write("Digite o texto a ser impresso: ");
        string texto = Console.ReadLine();
        _documento = new Documento(texto);
    }

   
    public void SolicitarQuantidadeCopias()
    {
        Console.Write("Digite a quantidade de cópias: ");
        _quantidadeCopias = int.Parse(Console.ReadLine());
    }
}