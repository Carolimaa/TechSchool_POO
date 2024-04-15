ComponenteSoftware software = new ComponenteSoftware("Back-End", "Guilherme - Alura");

Menu menuDoGolang = new Menu("Formação Go");

Curso curso1 = new Curso(software, "Go: a linguagem do Google")
{
    Duracao = 10,
    Disponivel = true,
};


Curso curso2 = new Curso(software, "Go: Orientação a Objetos")
{
    Duracao = 6,
    Disponivel = false,
};


Curso curso3 = new Curso(software, "Go: crie uma aplicação web")
{
    Duracao = 6,
    Disponivel = true,
};

Curso curso4 = new Curso(software, "Go: desenvolvendo uma API Rest")
{
    Duracao = 8,
    Disponivel = true,
};

Curso curso5 = new Curso(software, "Go e Gin: criando API rest com simplicidade")
{
    Duracao = 6,
    Disponivel = true,
};


Curso curso6 = new Curso(software, "Go: validações, testes e páginas HTML")
{
    Duracao = 8,
    Disponivel = true,
};


menuDoGolang.AdicionarCursos(curso1);
menuDoGolang.AdicionarCursos(curso2);
menuDoGolang.AdicionarCursos(curso3);
menuDoGolang.AdicionarCursos(curso4);
menuDoGolang.AdicionarCursos(curso5);
menuDoGolang.AdicionarCursos(curso6);

software.AdicionarMenu(menuDoGolang);

curso1.ExibirFichaTecnica();
curso2.ExibirFichaTecnica();
curso3.ExibirFichaTecnica();
curso4.ExibirFichaTecnica();
curso5.ExibirFichaTecnica();
curso6.ExibirFichaTecnica();

software.ExibirDescricao();
//menuDoGolang.ExibirCursosDoMenu();