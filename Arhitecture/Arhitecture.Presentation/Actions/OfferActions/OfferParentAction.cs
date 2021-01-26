﻿using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.OfferActions
{
    public class OfferParentAction : BaseParentAction
    {
        public OfferParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage offers";
        }

        public override void Call()
        {
            Console.WriteLine("Offer management");
            base.Call();
        }
    }
}
