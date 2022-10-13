using ExemploExplorando.Models;

//Criando Pessoas
Pessoa p1 = new Pessoa(nome: "Matheus", sobrenome: "Soares");
Pessoa p2 = new Pessoa(nome: "Glauberino", sobrenome: "Juscelino");


//Criando um curso e adicionando pessoas

Curso cursoDeingles = new Curso();

cursoDeingles.nome = "Inglês";
cursoDeingles.alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAluno(); 
