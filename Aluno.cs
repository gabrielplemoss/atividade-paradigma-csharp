using System;
namespace atividade
{
	class Aluno
	{
		private string nome;
		private double total;
		private string situacao;

		public void setNotas(double[] notas){	
			for(int i = 0; i < 3; i++){
				total = total + notas[i] ;
			}
		}

		public void setNome(string nome){
			this.nome = nome;
		}

		public double notaFinal(){
			return total;
		}

		public void setSituacao(){
			if(notaFinal() >= 60){
				situacao = "Aprovado";
			} else {
				situacao = "Reprovado";
			}	
		}
		
		public void resultadoFinal(){
			setSituacao();
			if(String.Compare(situacao, "Reprovado") == 0){
				Console.WriteLine("Reprovado");
				Console.WriteLine("Faltaram " + (60 - notaFinal()) +" pontos");
			} else {
				Console.WriteLine("Aprovado");
			}
		}
	}
}

