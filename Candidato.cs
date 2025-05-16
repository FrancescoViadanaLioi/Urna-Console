using System.Dynamic;
using System.Runtime.CompilerServices;

public class Candidato
{
    public string Nome { get; set; }
    public int Numero { get; set; }
    public int Votos{ get; private set; } = 0;

    public void ReceberVotos()
    {
        Votos++;
    }
}
