using System;
using atividade;

class HelloWorld {
  static void Main() {
    int opcao = 1;
    while(opcao != 0){
      Console.Clear();
      Console.WriteLine("--------------------MENU--------------------");
      Console.WriteLine("1 - Calcular a maior idade");
      Console.WriteLine("2 - Media salarial de 2 pessoas");
      Console.WriteLine("3 - calcular area,perimetro e diagonal do retangulo ");
      Console.WriteLine("4 - calcular salario de um funcionario");
      Console.WriteLine("5 - calcular media de um aluno");
      Console.WriteLine("0 - Sair");
      Console.Write("Escolha uma das opcoes: ");
      opcao = Int32.Parse(Console.ReadLine());

      switch (opcao) {
        case 0:
          break;
        case 1:{
          Console.Clear();
          Console.WriteLine("1 - Calcular a maior idade");
          string nome;
          int idade;
          Pessoa pessoa1 = new Pessoa();
          Pessoa pessoa2 = new Pessoa();

          Console.Write("nome:");
          nome = Console.ReadLine();
          pessoa1.setNome(nome);
          Console.Write("idade:");
          idade = Int32.Parse(Console.ReadLine());
          pessoa1.setIdade(idade);

          Console.Write("nome:");
          nome = Console.ReadLine();
          pessoa2.setNome(nome);
          Console.Write("idade:");
          idade = Int32.Parse(Console.ReadLine());
          pessoa2.setIdade(idade);

          if(pessoa1.getIdade() > pessoa2.getIdade()){
            Console.WriteLine("Pessoa mais velha: " + pessoa1.getNome());
          } else {
            Console.WriteLine("Pessoa mais velha: " + pessoa2.getNome());
          }

          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
        }
        case 2:{
          Console.Clear();
          Console.WriteLine("2 - Media salarial de 2 pessoas");

          MediaSalario func1 = new MediaSalario();				
          MediaSalario func2 = new MediaSalario();			

          string nome;
          double salario;

          Console.WriteLine("Dados do primeiro funcionario:");
          Console.Write("Nome: ");
          nome = Console.ReadLine();
          Console.Write("salario: ");
          salario = Int32.Parse(Console.ReadLine());
          func1.setNome(nome);
          func1.setSalario(salario);

          Console.WriteLine("Dados do segundo funcionario:");
          Console.Write("Nome: ");
          nome = Console.ReadLine();
          Console.Write("Salario: ");
          salario = Int32.Parse(Console.ReadLine());
          func2.setNome(nome);
          func2.setSalario(salario);

          Console.WriteLine("Salario medio R$:" + (func1.getSalario() + func2.getSalario()) / 2 );

          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
        }
        case 3:{
          Console.Clear();
          Console.WriteLine("3 - calcular area,perimetro e diagonal do retangulo ");
          Retangulo retangulo = new Retangulo();
          double altura;
          double largura;

          Console.WriteLine("Entre com a altura e largura do retangulo: ");

          altura = double.Parse(Console.ReadLine());
          largura = double.Parse(Console.ReadLine());

          retangulo.setLargura(altura);
          retangulo.setAltura(largura);
          Console.WriteLine("AREA = " + retangulo.area());
          Console.WriteLine("PERIMETRO = " + retangulo.perimetro());
          Console.WriteLine("DIAGONAL = " + retangulo.diagonal());
          
          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
        }
        case 4:{
          Console.Clear();
          Console.WriteLine("4 - calcular salario de um funcionario");

          Funcionario funcionario = new Funcionario();
          string nome;
          double salarioBruto;
          double imposto;
          double aumento;

          Console.Write("Nome: ");
          nome = Console.ReadLine();

          Console.Write("Salario bruto: ");
          salarioBruto = double.Parse(Console.ReadLine());

          Console.Write("Imposto: ");
          imposto = double.Parse(Console.ReadLine());

          funcionario.setNome(nome);
          funcionario.setSalarioBruto(salarioBruto);
          funcionario.setImposto(imposto);

          Console.WriteLine("Funcionario: " + funcionario.getNome() + ", R$: " + funcionario.salarioLiquido());
          Console.Write("Digite a porcentagem para aumentar o salario: ");
          aumento = double.Parse(Console.ReadLine());
          funcionario.aumentarSalario(aumento);

          Console.WriteLine("Dados atualizados: " + funcionario.getNome() + ", R$: " + funcionario.getSalarioComAumento());

          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
        }
        case 5:{
          Console.Clear();
          Console.WriteLine("5 - calcular media de um aluno");

          Aluno aluno = new Aluno();
          double[] notas = new double[3];
          string nome;

          Console.Write("Nome do Aluno: "); 
          nome = Console.ReadLine();
          aluno.setNome(nome);
          Console.WriteLine("Digite as tres notas do aluno: ");
          for(int i = 0; i < 3; i++){
            notas[i] = double.Parse(Console.ReadLine());
          }

          aluno.setNotas(notas);
          Console.WriteLine("NOTA FINAL = " + aluno.notaFinal());
          aluno.resultadoFinal();
          
          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
        }
        default:
          Console.Clear();
          Console.WriteLine("Numero Invalido");
          Console.WriteLine("Presione uma tecla para continuar");
          Console.ReadKey();
          break;
      }
    }
  }
}
