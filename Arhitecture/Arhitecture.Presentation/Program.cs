using Arhitecture.Presentation.Extensions;
using Arhitecture.Presentation.Factories;
using System;

namespace Arhitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenuActions = MainMenuFactory.GetMainMenuActions();
            mainMenuActions.PrintActionsAndCall();
        }
    }
}
