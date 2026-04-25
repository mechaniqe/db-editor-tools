# Editor Tools

Editor tools used in our projects. Provides Unity editor menu items for common developer tasks.

## 1. Getting Started

1. Open up project packages manifest JSON: `[Project Folder]/Packages/manifest.json`
2. Add the following line on top of dependencies:
   ```
   "net.dynamicbox.editortools": "https://github.com/mechaniqe/db-editor-tools.git",
   ```

The end result should be similar to:

```json
{
  "dependencies": {
    "net.dynamicbox.editortools": "https://github.com/mechaniqe/db-editor-tools.git",
    ...
  }
}
```

## 2. How to Use

All tools are accessible from the Unity menu bar under **Tools → DynamicBox**.

### 2.1 Deleting PlayerPrefs

Navigate to **Tools → DynamicBox → Delete data → PlayerPrefs** to clear all saved PlayerPrefs for the current project.

```
Tools/DynamicBox/Delete data/PlayerPrefs
```

### 2.2 Deleting App Data

Navigate to **Tools → DynamicBox → Delete data → App data** to delete the persistent data directory (`Application.persistentDataPath`) from disk.

```
Tools/DynamicBox/Delete data/App data
```

### 2.3 Deleting All Data

Navigate to **Tools → DynamicBox → Delete data → All** to clear both PlayerPrefs and app data in one step.

```
Tools/DynamicBox/Delete data/All
```

### 2.4 Reveal Data Path

Navigate to **Tools → DynamicBox → Reveal Data Path** to open the `Application.persistentDataPath` folder in the system file explorer.

```
Tools/DynamicBox/Reveal Data Path
```
