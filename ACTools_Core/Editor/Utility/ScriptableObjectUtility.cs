using System.IO;
using UnityEngine;
using UnityEditor;
using System.Threading.Tasks;

[HelpURL("https://wiki.unity3d.com/index.php/CreateScriptableObjectAsset")] // Reference to orignal concept.
public static class ScriptableObjectUtility
{
    /// <summary> Creates a new ScriptableObject asset, saves it in the project files, then returns the ScriptableObject. </summary>
    /// <typeparam name="T"> The type of ScriptableObject to be created. </typeparam>
    /// <returns> The new ScriptableObject that was created. </returns>
    public static T CreateAsset<T>() where T : ScriptableObject
    {
        T asset = ScriptableObject.CreateInstance<T>(); // Creates the instance of the scriptable object.

        string path = AssetDatabase.GetAssetPath(Selection.activeObject);   // Creates the path.

        if (path == "")
            path = "Assets";
        else if (Path.GetExtension(path) != "")
            path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

        SaveAssetInProjectFolders(asset, path); // Creates the asset in the project folders.

        return asset;   // Returns the scriptable object.
    }

    /// <summary> Creates a new ScriptableObject asset, saves it that the given path if it exists, then returns the ScriptableObject. </summary>
    /// <typeparam name="T"> The type of ScriptableObject to be created. </typeparam>
    /// <param name="path"> The path of folder where the asset will be saved if it exists. </param>
    /// <returns> The new ScriptableObject that was created. </returns>
    public static T CreateAsset<T>(string path) where T : ScriptableObject
    {
        T asset = ScriptableObject.CreateInstance<T>(); // Creates the instance of the scriptable object.

        if (!AssetDatabase.IsValidFolder(path)) // Checks to make sure the path exists.
            FolderUtility.CreateFolders(path);

        SaveAssetInProjectFolders(asset, path); // Creates the asset in the project folders.

        return asset;   // Returns the scriptable object.
    }

    /// <summary> Takes the asset and path and saves the assest at that path. </summary>
    /// <typeparam name="T"> The type of ScriptableObject to be created. </typeparam>
    /// <param name="asset"> The asset being created. </param>
    /// <param name="path"> The path the asset is to be saved at. </param>
    /// <returns> The new asset that was created. </returns>
    private static T SaveAssetInProjectFolders<T>(T asset, string path) where T : ScriptableObject
    {
        string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/New " + typeof(T).ToString() + ".asset");

        AssetDatabase.CreateAsset(asset, assetPathAndName); // Creates assest.

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;

        return asset;
    }
}