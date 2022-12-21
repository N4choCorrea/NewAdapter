using System;

namespace AdapterExample
{
    // Esta clase PlugAdapter implementa el patron de diseño Adapter debido a que adapta la clase Plug a la interface ISmartDevice
    public class PlugAdapter : ISmartDevice
    {
        private Plug plug;

        public PlugAdapter(Plug plug)
        {
            this.plug = plug;
        }
        public void On()
        {
            
            if (this.plug.GetStatus().Equals("off"))
            {
                this.plug.ToggleStatus();
                Console.WriteLine("The Plug is on");
            }
            
        }
        public void Off ()
        {
            
            if (this.plug.GetStatus().Equals("on"))
            {
                this.plug.ToggleStatus();
                Console.WriteLine("The Plug is off");
            }
            
        }
        public string GetStatus()
        {
            return this.plug.GetStatus();
        }
    }
   
    
}