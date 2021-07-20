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
    class Main
    {

        /*
         * 
         * imagine that this "logic" parameter came from a soapie in file or 
         * is used to determine the flow of the program before it runs
         * 
         * the implementations of the interfaces can be swapped and it makes
         * maintenance and adding new features cleaner and less likely to introduce accidental bugs
         * 
         * look at composedholder.cs
         * 
         */
        string logic = "Two";

        [Import("Strat", RequiredCreationPolicy = CreationPolicy.NonShared)]
       // [Import(RequiredCreationPolicy = CreationPolicy.Shared)]
        ComposedHolderStrategy c;

        public void Container()
        {
            //Everything here is simply necessary to get MEF to work. I didnt write this stuff
            var assem = System.Reflection.Assembly.GetExecutingAssembly();
            var cat = new AssemblyCatalog(assem);
            var compose = new CompositionContainer(cat);
            compose.ComposeParts(this);
        }

        public void Run() {
            Container(); //you need to call this so the code connects all the imports/exports
            //  op.doTheThing(); 

            c.DoTheThing(logic);
            //c.DoADiffThing(); this used to work, but as I was fixing stuff, it got 'sacrificed' because I thought it might have caused issues and I am too lazy to put it all back

            Console.WriteLine();
             
        }
    }
}
