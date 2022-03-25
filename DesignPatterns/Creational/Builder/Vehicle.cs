using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Vehicle
    {
        private string engine;
        private int wheel;

        private int airbags;

        public string GetEngine()
        {
            return this.engine;
        }

        public int GetWheel()
        {
            return this.wheel;
        }

        public int GetAirBags()
        {
            return this.airbags;
        }

        

        public class VehicleBuilder
        {

            private Vehicle _vehicle;

            public VehicleBuilder()
            {
                _vehicle = new Vehicle();
            }

            public VehicleBuilder SetEngineAndWheel(string engine, int wheel)
            {
                _vehicle.engine = engine;
                _vehicle.wheel = wheel;
                return this;
            }

            public VehicleBuilder SetAirBags(int airbags)
            {
                _vehicle.airbags = airbags;
                return this;
            }

            public Vehicle Build()
            {
                return _vehicle;
            }


        }
       
    }
}
