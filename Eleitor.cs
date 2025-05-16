using System;
using System.Diagnostics.Contracts;
using System.Dynamic;

public class Eleitor
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public bool JaVotou { get; private set; } = false;

    public void MarcarVoto()
    {
        if (JaVotou)
        {
            Console.WriteLine("O eleitor já votou.");
            return;
        }
        JaVotou = true;
    }
}