### Note: it is recommended to use the new Unity [input system](https://learn.unity.com/project/using-the-input-system-in-unity) instead.

# Unity Keybinds

Easily assign multiple keys to an action and manage your keybinds all in one script in Unity.

This script is free to use commercially.

## Example:

Keybinds.cs:
```
public static KeyCode[] MoveLeft {get; private set;} = {KeyCode.A, KeyCode.LeftArrow};
```

Movement.cs:
```
if (Keybinds.GetKeys(Keybinds.MoveLeft)) {
    // Move
}
```
