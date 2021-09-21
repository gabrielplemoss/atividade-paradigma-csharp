using System;

namespace atividade
{
  class Retangulo
  {
    private	double largura;
		private double altura;

    public double area(){
      return largura * altura;
    }

    public double perimetro(){
      return (2 * largura) + (2 * altura);
    }

    public double diagonal(){
      return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
    }

    public void setLargura(double largura) {
      this.largura = largura;
    }

    public void setAltura(double altura) {
      this.altura = altura;
    }
  }
}
