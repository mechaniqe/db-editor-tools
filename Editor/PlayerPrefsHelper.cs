using System.IO;
using UnityEditor;
using UnityEngine;

namespace DynamicBox.Editor
{
  public class PlayerPrefsHelper : MonoBehaviour
  {
    [MenuItem ("Tools/DynamicBox/Delete data/All")]
    public static void DeleteAll ()
    {
      DeletePlayerPrefs ();
      DeleteAppData ();
    }
    
    [MenuItem ("Tools/DynamicBox/Delete data/PlayerPrefs")]
    public static void DeletePlayerPrefs ()
    {
      PlayerPrefs.DeleteAll ();

      Debug.Log ($"<color=green>PlayerPrefs:</color> Cleared");
    }

    [MenuItem ("Tools/DynamicBox/Delete data/App data")]
    public static void DeleteAppData ()
    {
      if (Directory.Exists (Application.persistentDataPath))
      {
        Directory.Delete (Application.persistentDataPath, true);

        Debug.Log ($"<color=green>PlayerPrefs:</color> App data deleted");
      }
      else
      {
        Debug.LogWarning ($"<color=yellow>PlayerPrefs:</color> No app data found");
      }
    }
  }
}