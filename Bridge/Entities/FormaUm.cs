using Bridge.Entities.Interfaces;

namespace Bridge.Entities
{
    public class FormaUm : IForma
    {
        public ICor ICor { get; set; }
        public string Descer()
        {
            return "T - " + ICor.Cor();
        }
    }
}
