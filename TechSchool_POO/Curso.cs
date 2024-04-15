class Curso
{
    public Curso(ComponenteSoftware instrutor, string nome)
    {
        Instrutor = instrutor;
        Nome = nome;
    }
    public string Nome { get; }
    public ComponenteSoftware Instrutor { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida =>
        $"O curso {Nome} é passado pelo instrutor {Instrutor}";




    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Curso: {Nome}");
        Console.WriteLine($"Instrutor: {Instrutor.Instrutor}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano PRO.\n");
        }

    }
}
