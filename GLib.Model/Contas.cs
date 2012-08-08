using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLib.Model
{
    public class Contas
    {
        public virtual Int16 Id { get; set; }
        
        public virtual String Nome { get; set; }
        
        public virtual String Banco { get; set; }
        
        public virtual Int32 Agencia { get; set; }
        
        public virtual Int32 Conta { get; set; }
        
        public virtual String ToString()
        {
            return "ID: " + Id + ", Nome: " + Nome;
        }
    }
}
