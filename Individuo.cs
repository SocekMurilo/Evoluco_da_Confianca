public abstract class Individuo
{
    public abstract bool Interagir{get; set;}
    public int Moeda {get; set;} = 10;
    public abstract Individuo Clone();
    public virtual void Tapeado(){ }
    public virtual void Ajuda(){ }

}