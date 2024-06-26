using System;
using System.Collections.Generic;

List<Veiculo> veiculos = new List<Veiculo>();

Carro c1 = new Carro();
Moto m1 = new Moto();

veiculos.Add(c1);
veiculos.Add(m1);

foreach(var Veiculo in veiculos)
{
    Veiculo.Acelerar();
    Veiculo.ExibirVelocidade();
    Veiculo.Frear();
    Veiculo.ExibirVelocidade();
}