using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MEFTest.Factory;

namespace MEFTest
{
    [Export("Strat")]
    class ComposedHolderStrategy
    {
        [Import("IOPFactory")]
        IOpFactory factory;
      /* *//* [Import("DifOpFactory")]
        IDiffOp difffactory;
*//**/
        IOperationOfSomeSort op;
        //IOpThatsDiff diffop;
         
        public ComposedHolderStrategy() {
            
        }

        public void DoTheThing(string logic) {


            /*
             * 
             * the MEF framework creates the instance of the factory
             * 
             *   [Import("IOPFactory")] <- this replaces the "new" param for IOpFactory factory; For example MyClass a = new MyClass() everything to the right of '='
             *   is whats known as a dependency, which means if you update MyClass, you need to update every class that has an instance that is hard coded.
             *   
             *   Dependency injection fixes this problem, which means less coding over the days and months
             *   
             *   Look into the concept known as 'technical debt' for more info about that.
             *   
                In case you dont know, OpA, OpB and OpC can all be of type IOperationOfSomeSort. \
                If you wanted to do this the ass backwards way:
                IOperationOfSomeSort op = new OpA(); (using functions from op will run the functions of the same name in OpA)
                is just as valid as
                IOperationOfSomeSort op = new OpB(); (using functions from op will run the functions of the same name in OpB)
                is just as valid as
                IOperationOfSomeSort op = new OpC(); (using functions from op will run the functions of the same name in OpC)

             *  calling the functions from op will run whatever is on the right side of the '=' as long as the function names match & the class explicitly 
             *  uses the interface.  class OpA : IOperationOfSomeSort <-this part matters in the class definition
             *  
             *  
             *  Think of interfaces as a "contract"  saying "any class that implements this will follow these exact rules" so then you can write your code using interfaces (known as 'writing to the interface')
             *  and write as many implementations of the interface, and swap them whenever you want, and they can all do very different things depending on what you want the program to do
             *  without updating the main logic of the code (since it uses interfaces)
             * 
             */

            op = factory.createOp(logic);
            op.doTheThing();
        }

       /* public void DoADiffThing()
        {
            diffop = difffactory.createOp("Two");

            diffop.heyhey();
            Console.WriteLine(diffop.heyhey2());
          
        }*/

    }
}
