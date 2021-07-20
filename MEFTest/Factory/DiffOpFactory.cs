/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Composition;
namespace MEFTest.Factory
{
    [Export(typeof(IDiffOp))]
    class DiffOpFactory : IDiffOp
    {
        [ImportMany]
        List<IOperationOfSomeSort> ops;

        public IOperationOfSomeSort createOp(string logic)
        {
            return ops.Where(x => x.id().Equals(logic, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        }

        IOpThatsDiff IDiffOp.createOp(string logic)
        {
            throw new NotImplementedException();
        }
    }
}
*/