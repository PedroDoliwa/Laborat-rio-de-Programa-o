class Moto : Veiculo
{

    public override void Acelerar(){
        velocidade = velocidade + 15;
    }

    public override void Frear(){
        velocidade = velocidade - 10;
    }
}