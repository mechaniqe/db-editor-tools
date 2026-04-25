using UnityEditor;
using UnityEngine;

namespace DynamicBox.Editor
{
  public class SystemInfoHelper : MonoBehaviour
  {
    [MenuItem ("Tools/DynamicBox/Log Device Info")]
    public static void LogDeviceInfo ()
    {
      Debug.Log (
        $"<color=green>Device Info:</color>\n" +
        $"  OS: {SystemInfo.operatingSystem}\n" +
        $"  CPU: {SystemInfo.processorType} ({SystemInfo.processorCount} cores)\n" +
        $"  RAM: {SystemInfo.systemMemorySize} MB\n" +
        $"  GPU: {SystemInfo.graphicsDeviceName}\n" +
        $"  GPU Memory: {SystemInfo.graphicsMemorySize} MB\n" +
        $"  GPU API: {SystemInfo.graphicsDeviceType}\n" +
        $"  Device Model: {SystemInfo.deviceModel}\n" +
        $"  Device Type: {SystemInfo.deviceType}"
      );
    }
  }
}
