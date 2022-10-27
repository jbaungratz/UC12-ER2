// See https://aka.ms/new-console-template for more information


using UC12_ER2.Classes;
/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();
PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "José";
novaPf.dataNascimento = "14/11/1972";
novaPf.cpf = "01234567890";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Rua Cel Sarmento";
novoEnd.numero = 1459;
novoEnd.complemento = "apto 201";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}

");
*/

/*
novaPf.nome = "José";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/

//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));
//Console.WriteLine(novaPf.ValidarDataNascimento("2000,01,01"));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
//novaPj.cnpj = "01.001.001/0001-01";
novaPj.cnpj = "01001001000101";
novaPj.razaoSocial = "Razão Social Pj";
novaPj.rendimento = 8000;

novoEndPj.logradouro = "Rua Cel Sarmento";
novoEndPj.numero = 1459;
novoEndPj.complemento = "apto 201";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");



