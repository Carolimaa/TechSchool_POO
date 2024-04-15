class Menu
{
    private List<Curso> cursos = new List<Curso>();

    public Menu(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public int DuracaoTotal => cursos.Sum(c => c.Duracao);
    public void AdicionarCursos(Curso curso)
    {
        cursos.Add(curso);
    }

    public void ExibirCursosDoMenu()
    {
        Console.WriteLine($"Cursos da Formação {Nome}: \n");
        foreach (var curso in cursos)
        {
            Console.WriteLine($"Curso {curso.Nome}");
        }
        Console.WriteLine($"\nPara estudar a formação completa você precisa de {DuracaoTotal} horas.");
    }
}