using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype
    {
        string id;
        public int additionalProperty { get; set; }

        public Prototype(string id, int additionalProperty)
        {
            this.id = id;
            this.additionalProperty = additionalProperty;
        }

        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
   
    public class ConcretePrototype1 : Prototype
    {

        public ConcretePrototype1(string id, int additionalProperty)
            : base(id, additionalProperty)
        {
        }
       
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

   

}
