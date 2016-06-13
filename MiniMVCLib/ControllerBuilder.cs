using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMVCLib
{
    public class ControllerBuilder
    {
        private Func<IControllerFactory> factoryThunk;
        public static ControllerBuilder Current { get; private set; }
        static ControllerBuilder()
        {
            Current = new ControllerBuilder();
        }
        public HashSet<string> DefaultNamespaces { get; private set; }
        public ControllerBuilder()
        {
            DefaultNamespaces = new HashSet<string>();
        }
        public IControllerFactory GetControllerFactory()
        {
            return factoryThunk();
        }
        public void SetControllerFactory(IControllerFactory controllerFactory)
        {
            factoryThunk = () => controllerFactory;
        }
    }
}
