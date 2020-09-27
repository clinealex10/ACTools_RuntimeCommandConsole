using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace ACTools.DebugConsole
{
    //[CreateAssetMenu(fileName = "New Debug Controller", menuName = "ACTools/Debug Console/Debug Controller")]
    [System.Serializable]
    public class DebugController : ScriptableObject
    {
        public static DebugController Instance { get; protected set; } = null;

        public DebugConsole Console { get; private set; } = null;
        private List<object> commandList = new List<object>();
        public List<object> CommandList => commandList;

        public GameObject ConsolePrefab { get; private set; } = null;

        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            if (Instance == null)
                Instance = Resources.Load<DebugController>("ACTools/ScriptableObjects/Debug Controller");
            if (Instance.ConsolePrefab == null)
                Instance.ConsolePrefab = Resources.Load<GameObject>("ACTools/Prefabs/Debug Console");

            GameObject newConsole = Instantiate(Instance.ConsolePrefab);
            Instance.Console = newConsole.GetComponent<DebugConsole>();

            ListOfDebugCommands.InitializeCommandList(ref Instance.commandList);
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
                DebugCommandBase commandBase = CommandList[index] as DebugCommandBase;

                if (Console.InputValue.Contains(commandBase.CommandId))
                {
                    if (CommandList[index] as DebugCommand != null)
                        (CommandList[index] as DebugCommand).Invoke();
                    else if (CommandList[index] as DebugCommand<int> != null)
                        (CommandList[index] as DebugCommand<int>).Invoke(int.Parse(parameters[1]));
                    else if (CommandList[index] as DebugCommand<float> != null)
                        (CommandList[index] as DebugCommand<float>).Invoke(float.Parse(parameters[1]));
                    else if (CommandList[index] as DebugCommand<string> != null)
                        (CommandList[index] as DebugCommand<string>).Invoke(parameters[1]);
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