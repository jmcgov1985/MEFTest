using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Composition;
namespace MEFTest.Ops
{
    [Export]
    class OpC : IOperationOfSomeSort
    {
        public void doTheThing()
        {
            Console.WriteLine("This is a message from OpC!");
        }

        public String id()
        {

            return "Three";
        }
    }
}
