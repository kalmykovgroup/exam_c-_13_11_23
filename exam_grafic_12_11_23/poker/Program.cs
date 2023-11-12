using poker.backend;
using poker.frontend;
using System.Collections.Generic;

namespace poker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            ApplicationConfiguration.Initialize();
            FormController.Run(); 
        }
    }
}