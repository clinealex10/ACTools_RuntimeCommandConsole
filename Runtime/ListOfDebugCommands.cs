using System.Collections.Generic;
using UnityEngine;

namespace ACTools.DebugConsole
{
    public static class ListOfDebugCommands
    {
        // Here is where you can declare your debug commands.
        public static DebugCommand help;
        public static DebugCommand debugConsoleCreator;
        public static DebugCommand<string> printToConsole;

        /// <summary> Initalizes the list of commands. </summary>
        public static void InitializeCommandList(ref List<object> CommandList)
        {
            // Here is where you can set their value.
            help = new DebugCommand("help", "Displays all of the commands this console has.", "help", () =>
            {
                DebugController.Instance.Console.OnToggleHelp();
            });
            debugConsoleCreator = new DebugCommand("debug_console_creator", "Prints the creator of this debug console to the Unity Console.", "debug_console_creator", () =>
            {
                Debug.Log("ACTools: Debug Console - Created by Alex Cline");
            });
            printToConsole = new DebugCommand<string>("print_to_console", "Prints the creator of this debug console to the Unity Console.", "print_to_console <message>", (parameter) =>
            {
                Debug.Log($"Message from debug console: {parameter}");
            });

            // Here is where you add the debug command to the list of commands.
            CommandList = new List<object>
            {
                help,
                debugConsoleCreator,
                printToConsole,
            };
        }
    }
}