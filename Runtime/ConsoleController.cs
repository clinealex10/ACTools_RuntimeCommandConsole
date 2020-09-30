using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace ACTools.RuntimeCommandConsole
{
    //[CreateAssetMenu(fileName = "New Debug Controller", menuName = "ACTools/Debug Console/Debug Controller")]
    [System.Serializable]
    public class ConsoleController : ScriptableObject
    {
        public static ConsoleController Instance { get; protected set; } = null;

        public ConsoleCanvas Console { get; private set; } = null;

        public List<object> CommandList => CommandCollection.CommandList;

        public GameObject ConsolePrefab { get; private set; } = null;

        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            if (Instance == null)
                Instance = Resources.Load<ConsoleController>("ACTools/ScriptableObjects/Console Controller");
            if (Instance.ConsolePrefab == null)
                Instance.ConsolePrefab = Resources.Load<GameObject>("ACTools/Prefabs/Console Canvas");

            GameObject newConsole = Instantiate(Instance.ConsolePrefab);
            Instance.Console = newConsole.GetComponent<ConsoleCanvas>();

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
        public void HandleInput()
        {
            string[] parameters = Console.InputValue.Split(' ');

            for (int index = 0; index < CommandList.Count; index++)
            {
                CommandBase commandBase = CommandList[index] as CommandBase;

                if (Console.InputValue.Contains(commandBase.CommandId))
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
            }
        }

        /// <summary> Set's this console equal to null. </summary>
        public void RemoveConsole()
        {
            Console = null;
        }
    }
}