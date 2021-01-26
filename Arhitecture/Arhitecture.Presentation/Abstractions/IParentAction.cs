using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Abstractions
{
    interface IParentAction : IAction
    {
        IList<IAction> Actions { get; set; }
    }
}
