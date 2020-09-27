using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace ACTools.DebugConsole
{
    public class DebugConsoleInitializer : EditorWindow
    {
        private Button createFolders;
        private Button createAssets;
        //private Button setupInput;

        private string assetPathToControllerFolder = "Assets/Resources/ACTools/ScriptableObjects";
        private string resourcesPathToController = "ACTools/ScriptableObjects/Debug Controller";

        private string packagePathToConsolePrefab = "Packages/com.actools.debugconsole/Prefabs/Debug Console.prefab";
        private string assetPathToConsolePrefab = "Assets/Resources/ACTools/Prefabs/Debug Console.prefab";

        private string assetPathToConsolePrefabFolder = "Assets/Resources/ACTools/Prefabs";
        private string resourcesPathToConsolePrefab = "ACTools/Prefabs/Debug Console";

        //private int toggleConsoleIndex = 0;
        //private int submitIndex = 2;
        //private int toggleInputFieldSelected = 11;

        [MenuItem("Tools/ACTools/Debug Console/Initialize Console")]
        public static void OpenWindow()
        {
            DebugConsoleInitializer wnd = GetWindow<DebugConsoleInitializer>();
            wnd.titleContent = new GUIContent("Debug Console Initializer");

            wnd.minSize = new Vector2(400f, 180f);
            wnd.maxSize = new Vector2(400f, 180f);
        }

        public void OnEnable()
        {
            VisualElement root = rootVisualElement;

            createFolders = new Button(() => GenerateFolders());
            createFolders.text = "Generate Required Folders";
            createFolders.tooltip = "These folders are required for this package to function. You can move the Resources folder. DO NOT MOVE THE FOLDERS INSIDE THE RESOURCES FOLDER.";

            if (AssetDatabase.IsValidFolder(assetPathToControllerFolder) && AssetDatabase.IsValidFolder(assetPathToControllerFolder))
                createFolders.SetEnabled(false);

            root.Add(createFolders);

            createAssets = new Button(() => GenerateAssets());
            createAssets.text = "Generate Required Assets";
            createAssets.tooltip = "These assets need to be generated into specific folders. DO NOT MOVE THESE ASSETS FROM THESE FILES.";

            if (createFolders.enabledSelf || Resources.Load<DebugController>(resourcesPathToController) != null && Resources.Load<GameObject>(resourcesPathToConsolePrefab) != null)
                createAssets.SetEnabled(false);

            root.Add(createAssets);
/*
            setupInput = new Button(() => SetUpInput());
            setupInput.text = "Set up Input";
            setupInput.tooltip = "Sets up the input from the Debug Console to the Debug Controller.";

            if (createAssets.enabledSelf)
                setupInput.SetEnabled(false);

            root.Add(setupInput);*/
        }

        /// <summary> Generates required folder paths. </summary>
        public void GenerateFolders()
        {
            FolderUtility.CreateFolders(assetPathToControllerFolder);
            FolderUtility.CreateFolders(assetPathToConsolePrefabFolder);
            createAssets.SetEnabled(true);
        }

        /// <summary> Generates required assets. </summary>
        public void GenerateAssets()
        {
            if (Resources.Load<DebugController>(resourcesPathToController) == null)
            {
                ScriptableObjectUtility.CreateAsset<DebugController>(assetPathToControllerFolder);

                AssetDatabase.RenameAsset(assetPathToControllerFolder + "/New ACTools.DebugConsole.DebugController.asset", "Debug Controller");
            }
            else
                Debug.LogAssertion("Your debug console is already initialized.");


            if (Resources.Load<GameObject>(resourcesPathToConsolePrefab) == null)
                AssetDatabase.CopyAsset(packagePathToConsolePrefab, assetPathToConsolePrefab);
            else
                Debug.LogAssertion("Your debug console prefab is already initialized.");
/*
            setupInput.SetEnabled(true);*/
        }
/*
        /// <summary> Sets up the input for the users during Runtime. </summary>
        public void SetUpInput()
        {
            DebugController controller = Resources.Load<DebugController>(resourcesPathToController);
            PlayerInput input = Resources.Load<GameObject>(resourcesPathToConsolePrefab).GetComponent<PlayerInput>();

            input.actionEvents[toggleConsoleIndex].AddListener((context) => controller.CreateOrToggleConsole(context)); <- When assigned, the target within each element is n When manual set, it works find.
            input.actionEvents[submitIndex].AddListener((context) => controller.OnSubmit(context));
            input.actionEvents[toggleInputFieldSelected].AddListener((context) => controller.SelectInputField(context));

            Close();
        }*/
    }
}