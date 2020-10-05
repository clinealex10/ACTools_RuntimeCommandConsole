using System;
using System.Collections.Generic;

namespace ACTools.RuntimeCommandConsole
{
    public static class CommandCollection
    {
        public static List<object> CommandList { get; private set; } = new List<object>();

        /// <summary> Adds a command to the list of avaliable commands. </summary>
        /// <param name="id"> ID of the command. </param>
        /// <param name="description"> What the command does. </param>
        /// <param name="format"> How to write the command. </param>
        /// <param name="newCommand"> The action that is called when the command is invoked. </param>
        public static void AddCommand(string id, string description, string format, Action newCommand)
        {
            CommandList.Add(new Command(id, description, format, newCommand));
        }

        /// <summary> Adds a command to the list of avaliable commands. </summary>
        /// <typeparam name="T0"> Type of parameter this command should exact. </typeparam>
        /// <param name="id"> ID of the command. </param>
        /// <param name="description"> What the command does. </param>
        /// <param name="format"> How to write the command. </param>
        /// <param name="newCommand"> The action that is called when the command is invoked. </param>
        public static void AddCommand<T0>(string id, string description, string format, Action<T0> newCommand)
        {
            CommandList.Add(new Command<T0>(id, description, format, newCommand));
        }

        /// <summary> Resets the list of commands. </summary>
        internal static void ResetList()
        {
            CommandList = new List<object>();
        }
    }
}