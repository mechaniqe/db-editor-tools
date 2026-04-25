using UnityEditor;
using UnityEngine;

namespace DynamicBox.Editor
{
  public class OpenPersistentDataPath : MonoBehaviour
  {
    [MenuItem ("Tools/DynamicBox/Reveal Data Path")]
    public static void RevealDataPathFolder ()
    {
      EditorUtility.RevealInFinder (Application.persistentDataPath);
    }

    [MenuItem ("Tools/DynamicBox/Copy Data Path")]
    public static void CopyDataPathToClipboard ()
    {
      EditorGUIUtility.systemCopyBuffer = Application.persistentDataPath;

      Debug.Log ($"<color=green>Data Path:</color> Copied to clipboard → {Application.persistentDataPath}");
    }
  }
}