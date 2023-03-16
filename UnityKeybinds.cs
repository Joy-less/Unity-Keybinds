using UnityEngine;

// Created by Joyless
public class Keybinds : MonoBehaviour
{
    public static KeyCode[] MoveLeft {get; private set;} = {KeyCode.A, KeyCode.LeftArrow};
    public static KeyCode[] MoveRight {get; private set;} = {KeyCode.D, KeyCode.RightArrow};

    ///<summary>Returns true while the user holds down any of the keys</summary>
    public static bool GetKeys(KeyCode[] Keys) {
        return GetKeysBase(Keys, Input.GetKey);
    }
    ///<summary>Returns true during the frame the user starts pressing down any of the keys</summary>
    public static bool GetKeysDown(KeyCode[] Keys) {
        return GetKeysBase(Keys, Input.GetKeyDown);
    }
    ///<summary>Returns true during the frame the user releases any of the keys</summary>
    public static bool GetKeysUp(KeyCode[] Keys) {
        return GetKeysBase(Keys, Input.GetKeyUp);
    }
    private static bool GetKeysBase(KeyCode[] Keys, System.Func<KeyCode, bool> Function) {
        foreach (KeyCode Key in Keys) {
            if (Function(Key) == true) {
                return true;
            }
        }
        return false;
    }
}
