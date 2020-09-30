using System;

namespace ACTools.RuntimeCommandConsole
{
    public class CommandBase
    {
        private string commandId = "";
        private string commandDescription = "";
        private string commandFormat = "";

        public string CommandId => commandId;
        public string CommandDescription => commandDescription;
        public string CommandFormat => commandFormat;

        /// <summary> Constructor for the base debug command. </summary>
        /// <param name="id"> ID of the command. </param>
        /// <param name="description"> What the command does. </param>
        /// <param name="format"> How to write the command. </param>
        public CommandBase(string id, string description, string format)
        {
            commandId = id;
            commandDescription = description;
            commandFormat = format;
        }
    }

    public class Command : CommandBase
    {
        private Action command;

        /// <summary> Constructor for the debug command. </summary>
        /// <param name="id"> ID of the command. </param>
        /// <param name="description"> What the command does. </param>
        /// <param name="format"> How to write the command. </param>
        /// <param name="newCommand"> The action that is called when the command is invoked. </param>
        public Command(string id, string description, string format, Action newCommand) : base (id, description, format)
        {
            command = newCommand;
        }

        /// <summary> Executes this command's function. </summary>
        public void Invoke()
        {
            command.Invoke();
        }
    }

    public class Command<T1> : CommandBase
    {
        private Action<T1> command;

        /// <summary> Constructor for the debug command. </summary>
        /// <param name="id"> ID of the command. </param>
        /// <param name="description"> What the command does. </param>
        /// <param name="format"> How to write the command. </param>
        /// <param name="newCommand"> The action that is called when the command is invoked. </param>
        public Command(string id, string description, string format, Action<T1> newCommand) : base (id, description, format)
        {
            command = newCommand;
        }

        /// <summary> Executes this command's function. </summary>
        /// <param name="value"> The value being based to this command's function. </param>
        public void Invoke(T1 value)
        {
            command.Invoke(value);
        }
    }
}