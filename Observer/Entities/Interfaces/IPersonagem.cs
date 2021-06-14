namespace Observer.Entities.Interfaces
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagens();
    }
}
