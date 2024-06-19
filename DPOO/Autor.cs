public class Autor {
    string nome;
    string nacionalidade;


    public Autor (string Rnome, string Rnacionalidade){
        nome = Rnome;
        nacionalidade = Rnacionalidade;
    }


    public void  MostrarInfo() {
        Console.WriteLine($"Nome: {nome}\n Nacionalidade: {nacionalidade}");


       // return nome + " " + nacionalidade;
    }
}