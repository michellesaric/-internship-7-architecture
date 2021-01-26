﻿using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.BillActions
{
    public class BillParentAction : BaseParentAction
    {
        public BillParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage bills";
        }

        public override void Call()
        {
            Console.WriteLine("Bill management");
            base.Call();
        }
    }
}
