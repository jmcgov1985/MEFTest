using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Composition;
namespace MEFTest.Factory
{
    //[Export(typeof(IOperationOfSomeSort))]
    class OpFactory : IOpFactory
    {
        [ImportMany]
        List<IOperationOfSomeSort> ops;

        public IOperationOfSomeSort createOp(string logic)
        {
            return ops.Where(x => x.id().Equals(logic)).FirstOrDefault();
        }

      
    }
}
