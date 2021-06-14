using Bridge.Entities.Interfaces;

namespace Bridge.Entities
{
    public class FormaDois : IForma
    {
        public ICor ICor { get; set; }
        public string Descer()
        {
            return "U - " + ICor.Cor();
        }
    }
}
