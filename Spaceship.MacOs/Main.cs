using System;
using System.Collections.Generic;
using System.Linq;
using AppKit;
using Foundation;

namespace Spaceship.MacOs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            NSApplication.Init();

            using (var game = new LeoApp.Spaceship())
            {
                game.Run();
            }
        }
    }
}
