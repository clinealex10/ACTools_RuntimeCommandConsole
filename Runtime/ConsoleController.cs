using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace ACTools.RuntimeCommandConsole
{
    //[CreateAssetMenu(fileName = "Console Controller", menuName = "Tools/ACTools/Runtime Command Console/Console Controller")]
    [Serializable]
    public class ConsoleController : ScriptableObject
    {
        public static ConsoleController Instance { get; protected set; } = null;

        public ConsoleCanvas Console { get; private set; } = null;

        public List<object> CommandList => CommandCollection.CommandList;

        public GameObject ConsolePrefab { get; private set; } = null;

        [RuntimeInitializeOnLoadMethod]
        internal static void Initialize()
        {
            if (Instance == null)
                Instance = Resources.Load<ConsoleController>("ACTools/ScriptableObjects/Console Controller");
            if (Instance.ConsolePrefab == null)
                Instance.ConsolePrefab = Resources.Load<GameObject>("ACTools/Prefabs/Console Canvas");

            GameObject newConsole = Instantiate(Instance.ConsolePrefab);
            Instance.Console = newConsole.GetComponent<ConsoleCanvas>();
            Instance.Console.SetInputDevice();

            CommandCollection.AddCommand("help", "Displays all of the commands this console has.", "help", () => Instance.Console.OnToggleHelp());
            CommandCollection.AddCommand("command_console_creator", 
                                                "Prints the creator of this debug console to the Unity Console.", 
                                                "debug_console_creator", 
                                                () => Debug.Log("ACTools: Runtime Command Console - Created by Alex Cline"));
        }

        /// <summary> Toggles the debug console. If it's not within the scene, one will be created. </summary>
        /// <param name="context"> Context of the input provide by the user. </param>
        public void CreateOrToggleConsole(CallbackContext context)
        {
            if (!context.performed)
                return;

            Console.OnToggleConsole();
        }

        /// <summary> Executes on the input within the text box. </summary>
        /// <param name="context"> Context of the input provide by the user. </param>
        public void OnSubmit(CallbackContext context)
        {
            if (!context.performed)
                return;

            if (Console.ShowConsole)
            {
                HandleInput();
                Console.InputValue = "";
            }
        }

        /// <summary> Selects the input field. </summary>
        public void SelectInputField(CallbackContext context)
        {
            if (!context.performed && Console.ShowConsole)
                return;

            Console.SelectInputField();
        }

        /// <summary> Reads the input of the user. </summary>
        internal void HandleInput()
        {
            string[] parameters = Console.InputValue.Split(' ');

            for (int index = 0; index < CommandList.Count; index++)
            {
                CommandBase commandBase = CommandList[index] as CommandBase;

                if (Console.InputValue.Contains(commandBase.CommandId))
                    InvokeCommandBasedOnType(index, parameters);
            }
        }

        /// <summary> Invokes a command based on the given parameters and index. </summary>
        /// <param name="index"> The index of the command in CommandList. </param>
        /// <param name="parameters"> Possible parameter values to invoke the event with. </param>
        public virtual void InvokeCommandBasedOnType(int index, string[] parameters)
        {
            if (CommandList[index] as Command != null)
                (CommandList[index] as Command).Invoke();
            else if (CommandList[index] as Command<int> != null)
                (CommandList[index] as Command<int>).Invoke(int.Parse(parameters[1]));
            else if (CommandList[index] as Command<float> != null)
                (CommandList[index] as Command<float>).Invoke(float.Parse(parameters[1]));
            else if (CommandList[index] as Command<string> != null)
                (CommandList[index] as Command<string>).Invoke(parameters[1]);
        }

        /// <summary> Set's this console equal to null. </summary>
        internal void RemoveConsole()
        {
            Console = null;
        }
    }
}