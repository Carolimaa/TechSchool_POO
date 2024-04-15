class ComponenteSoftware
{
    private List<Menu> menus = new List<Menu>();

    public ComponenteSoftware(string nome, string instrutor)
    {
        Instrutor = instrutor;
        Nome = nome;
    }

    public string Instrutor { get; set; }

    public string Nome { get; }

    public void AdicionarMenu(Menu menu)
    {
        menus.Add(menu);
    }

    public void ExibirDescricao()
    {
        Console.WriteLine($"Componente de Software: {Nome}");
        foreach (Menu menu in menus)
        {
            Console.WriteLine($"Curso: {menu.Nome} ({menu.DuracaoTotal}) horas.");
        }
    }
}