namespace atividade
{
  class Pessoa
  {
    private string nome;
    private int idade;
  
    public void setNome(string nome){
      this.nome = nome;
    }
  
    public string getNome(){
      return nome;
    }
  
    public void setIdade(int idade){
      this.idade = idade;
    }
  
    public int getIdade(){
      return idade;
    }
  }
}
