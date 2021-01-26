using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.CategoryActions
{
    public class CategoryParentAction : BaseParentAction
    {
        public CategoryParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage categories";
        }

        public override void Call()
        {
            Console.WriteLine("Category management");
            base.Call();
        }
    }
}
