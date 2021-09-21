namespace atividade
{
	class Funcionario
	{
		private string nome;
		private double salarioBruto;
		private double salarioComAumento;
		private double imposto;

		public double salarioLiquido(){
			return salarioBruto - imposto;
		}

		public void aumentarSalario(double porcentagem){
			salarioComAumento = salarioBruto + (salarioBruto * (porcentagem / 100)) - imposto;
		}

		public void setNome(string nome){
			this.nome = nome;
		}

		public string getNome(){
			return nome;
		}

		public void setSalarioBruto(double salarioBruto){
			this.salarioBruto = salarioBruto;
		}

		public void setImposto(double imposto){
			this.imposto = imposto;
		}

		public double getSalarioComAumento(){
			return salarioComAumento;
		}
	}
}
