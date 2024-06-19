public class Livro{

    public string titulo;
    public double preco;
    public Autor autor;

    public Livro (string Rtitulo, Autor Rautor){
        titulo = Rtitulo;
        autor = Rautor;
    }

        public Livro (string Rtitulo, Autor Rautor, double Rpreco){
        titulo = Rtitulo;
        autor = Rautor;
        preco = Rpreco;
    }

    public void MostrarInfo(){
         Console.WriteLine($"Titulo: {titulo}\nPreco: {preco}\nAutor: {autor}");
    }

    public void AplicarDesconto(double Vdesc){
        preco = preco - (Vdesc/100);
        Console.WriteLine($"Preco atual: {preco}");
    }

    public void AplicarDesconto(int Vdesc){
        preco = preco - Vdesc;
        Console.WriteLine($"Preco atual: {preco}");

    }

}