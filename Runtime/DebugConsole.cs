using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace ACTools.DebugConsole
{
    public class DebugConsole : MonoBehaviour
    {
        [SerializeField] private Canvas debugCanvas = null;

        [Space]

        [SerializeField] private ScrollRect helpView = null;
        [SerializeField] private GameObject helpContent = null;

        [Space]

        [SerializeField] private ScrollRect suggestionView = null;
        [SerializeField] private GameObject suggestionContent = null;

        [Space]

        [SerializeField] private GameObject scrollItemPrefab = null;

        [Space]

        [SerializeField] private TMP_InputField inputField = null;

        private float ScrollItemHeight => (scrollItemPrefab.transform as RectTransform).rect.height;

        public bool ShowConsole => debugCanvas.enabled;
        public bool ShowHelp => helpView.gameObject.activeSelf;
        public string InputValue { get => inputField.text; set => inputField.text = value; }

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            debugCanvas.enabled = false;
            helpView.gameObject.SetActive(false);
        }

        private void Start()
        {
            DrawScrollingItems(helpContent, DebugController.Instance.CommandList);
        }

        private void OnDestroy()
        {
            DebugController.Instance.RemoveConsole();
        }

        /// <summary> Toogles the Debug Console GUI on and off. </summary>
        public void OnToggleConsole()
        {
            InputValue = "";
            debugCanvas.enabled = !debugCanvas.enabled;
            suggestionView.gameObject.SetActive(false);

            if (ShowConsole)
                inputField.Select();
        }

        /// <summary> Toogles the help GUI on and off. </summary>
        public void OnToggleHelp()
        {
            helpView.gameObject.SetActive(!helpView.gameObject.activeSelf);
        }

        /// <summary> Selects the input field. </summary>
        public void SelectInputField()
        {
            if (ShowConsole)
                inputField.Select();
        }

        /// <summary> Creates the button suggestion elements. </summary>
        public void DrawSuggestions()
        {
            for (int index = suggestionContent.transform.childCount - 1; index >= 0; index--)
            {
                Destroy(suggestionContent.transform.GetChild(index).gameObject);
            }

            if (!InputValue.Equals(""))
            {
                List<object> commandsContainingInput = new List<object>();
                for (int index = 0; index < DebugController.Instance.CommandList.Count; index++)
                {
                    DebugCommandBase commandBase = DebugController.Instance.CommandList[index] as DebugCommandBase;
                    if (commandBase.CommandId.Contains(InputValue))
                        commandsContainingInput.Add(DebugController.Instance.CommandList[index]);
                }

                if (commandsContainingInput.Count > 0)
                {
                    DrawScrollingItems(suggestionContent, commandsContainingInput);
                    suggestionView.gameObject.SetActive(true);
                }
                else
                    suggestionView.gameObject.SetActive(false);
            }
            else
                suggestionView.gameObject.SetActive(false);
        }

        /// <summary> Draws a scrolling collection of buttons. </summary>
        /// <param name="contentContainer"> The container to put the buttons in. </param>
        /// <param name="objList"> The list of objects. </param>
        private void DrawScrollingItems(GameObject contentContainer, List<object> objList)
        {
            for (int index = 0; index < objList.Count; index++)
            {
                DebugCommandBase commandBase = objList[index] as DebugCommandBase;

                string label = $"   {commandBase.CommandFormat} - {commandBase.CommandDescription}";

                GameObject newItem = Instantiate(scrollItemPrefab, contentContainer.transform, false);
                (newItem.transform as RectTransform).localPosition = (Vector3.down * ScrollItemHeight * index);
                (newItem.transform as RectTransform).anchoredPosition *= Vector2.up;

                newItem.name = commandBase.CommandId;
                newItem.GetComponentInChildren<TMP_Text>().text = label;
                newItem.GetComponent<Button>().onClick.AddListener(() => {
                    InputValue = newItem.name;
                    SelectInputField();
                });
            }

            (contentContainer.transform as RectTransform).sizeDelta = Vector2.one * ScrollItemHeight * objList.Count;
        }
    }
}