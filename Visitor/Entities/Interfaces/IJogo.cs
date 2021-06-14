using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Entities.Interfaces
{
    public interface IJogo
    {
        void Visitante(IVisitor visitante);
    }
}
