public class Tolerante : Individuo
{
    int enganado = 3;
    int enganando = 0;
    public override bool Interagir()
    {
        if (enganando > 0)
        {
            enganando --;
            return false;
        }
        return true;
    }
    public override void Tapeado()
    {
        enganado++;
        if (enganado == 3)
        {
            enganado = 0;
            enganando = 3;
        }

    }
    public override Individuo Clone()
    {
        throw new NotImplementedException();
    }

}