using UnityEngine.UIElements;

public static class VisualElementExtensions
{
    /// <summary> Sets up this visual element's name and class. </summary>
    /// <typeparam name="T"> Type of this visual element. </typeparam>
    /// <param name="element"> This visual element. </param>
    /// <param name="name"> Name of this visual element. </param>
    /// <param name="ussClass"> Class to add to this visual element. </param>
    public static void VisualElementSetup<T>(this T element, string name, string ussClass) where T : VisualElement
    {
        element.name = name;
        element.AddToClassList(ussClass);
    }

    /// <summary> Sets up this visual element's name and classes. </summary>
    /// <typeparam name="T"> Type of this visual element. </typeparam>
    /// <param name="element"> This visual element. </param>
    /// <param name="name"> Name of this visual element. </param>
    /// <param name="ussClasses"> Classes to add to this visual element. </param>
    public static void VisualElementSetup<T>(this T element, string name, string[] ussClasses) where T : VisualElement
    {
        element.name = name;
        for (int index = 0; index < ussClasses.Length; index++)
        {
            element.AddToClassList(ussClasses[index]);
        }
    }
}