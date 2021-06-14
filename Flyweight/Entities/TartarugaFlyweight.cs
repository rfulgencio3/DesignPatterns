using System.Collections.Generic;

namespace Flyweight.Entities
{
    public class TartarugaFlyweight
    {
        private Dictionary<string, Tartaruga> ListaTartaruga = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (ListaTartaruga.ContainsKey(cor))
            {
                tartaruga = ListaTartaruga[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        tartaruga = new Azul();
                        break;
                    case "verde":
                        tartaruga = new Verde();
                        break;
                    case "laranja":
                        tartaruga = new Laranja();
                        break;
                    case "vermelha":
                        tartaruga = new Vermelha();
                        break;
                }
                ListaTartaruga.Add(cor, tartaruga);
            }
            return tartaruga;
        }
    }
}
