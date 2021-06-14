using Command.Entities.Interfaces;

namespace Command.Entities
{
    public partial class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            this._receiver.PrimeiroPedido(this._a);
            this._receiver.SegundoPedido(this._b);
        }
    }
}
