using System;
using System.Collections.Generic;
using UnityEditor;

public static class FolderUtility
{
    private static char pathSpliter = '/';  // Char that splits path strings.

    /// <summary> Takes a given path and creates the folders to generate that path if it doesn't already exist. </summary>
    /// <param name="path"> The path with the folders to be created. </param>
    public static void CreateFolders(string path)
    {
        if (AssetDatabase.IsValidFolder(path))  // Returns if the path already exists.
            return;

        string[] folders = path.Split(pathSpliter); // Splits the path of the folders that need to be created.

        string tempPath = folders[0];

        for (int index1 = 1; index1 < folders.Length; index1++)    // Loops through folder names to adjust the value of the tempPath.
        {
            if (!AssetDatabase.IsValidFolder(tempPath + "/" + folders[index1]))
                AssetDatabase.CreateFolder(tempPath, folders[index1]);

            tempPath += "/" + folders[index1];
        }
    }
    
    /// <summary> Finds assets of a given type in the project files. </summary>
    /// <param name="givenType"> Type of asset being searched for. </param>
    /// <returns> List of all assets of that type as UnityEngine.Objects. </returns>
    public static List<UnityEngine.Object> FindAssetsByType(Type givenType)
    {
        string[] guids = AssetDatabase.FindAssets(string.Format("t:{0}", givenType));

        List<UnityEngine.Object> assets = new List<UnityEngine.Object>();

        for (int index = 0; index < guids.Length; index++)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guids[index]);
            UnityEngine.Object asset = AssetDatabase.LoadAssetAtPath(assetPath, givenType);
            if (asset != null)
                assets.Add(asset);
        }
        return assets;
    }

    // https://answers.unity.com/questions/486545/getting-all-assets-of-the-specified-type.html
    /// <summary> Finds assets of a given type in the project files. </summary>
    /// <typeparam name="T"> Type of asset being searched for. </typeparam>
    /// <returns> List of all assets of that type. </returns>
    public static List<T> FindAssetsByType<T>() where T : UnityEngine.Object
    {
        string[] guids = AssetDatabase.FindAssets(string.Format("t:{0}", typeof(T)));

        List<T> assets = new List<T>();

        for (int index = 0; index < guids.Length; index++)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guids[index]);
            T asset = AssetDatabase.LoadAssetAtPath<T>(assetPath);
            if (asset != null)
                assets.Add(asset);
        }
        return assets;
    }

    /// <summary> Searches project folders for specified types of objects. </summary>
    /// <typeparam name="T"> The type of object being searched for. </typeparam>
    /// <param name="searchFolders"> The folders to be searched in the process. </param>
    /// <returns> A list of found objects of the given type. </returns>
    public static List<T> FindAssetsByType<T>(string[] searchFolders) where T : UnityEngine.Object
    {
        for (int index = 0; index < searchFolders.Length; index++)
        {
            CreateFolders(searchFolders[index]);
        }

        string[] guidStrings = AssetDatabase.FindAssets(string.Format("t:{0}", typeof(T)), searchFolders);  // Finds possible assets.

        List<T> returnList = new List<T>();

        for (int index = 0; index < guidStrings.Length; index++)    // Loads assest into array.
        {
            string path = AssetDatabase.GUIDToAssetPath(guidStrings[index]);
            T temp = AssetDatabase.LoadAssetAtPath<T>(path);
            returnList.Add(temp);
        }
        return returnList;
    }
}