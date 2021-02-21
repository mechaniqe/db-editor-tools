using UnityEditor;
using UnityEngine;

namespace DynamicBox.Editor
{
  public class OpenPersistentDataPath : MonoBehaviour
  {
    [MenuItem ("DynamicBox/Reveal Data Path")]
    public static void RevealDataPathFolder ()
    {
      EditorUtility.RevealInFinder (Application.persistentDataPath);
    }
  }
}