﻿/* singelton implementation Fix issue 1 
 * this version of the singelton implementation has some issues:
 * 1) Singleton is not persistent across the Unity scenes.
 * 2) All the executable code must be attached to GameObject in the hierarchy.
 * 3) It is not recommended to call SingletonController.Instance in any Awake() method because, since we don’t know the order that Awake() will be executed through all scripts, we can end up with a Null Reference Exception.
 * 4) This code works only for SingletonController Class, but if you want another singleton controller e.g., AudioController, we have to copy paste the same code to AudioController Class and do some minor changes to works, but this leads to boilerplate code.
 */
using UnityEngine;

public class SingletonControllerFixIssue4 : GenericSingletonClass<SingletonControllerFixIssue4> {

    private string name = "";

    public string Name
    {
        get
        {
            Debug.Log("get name " + name);
            return name;
        }

        set
        {
            name = value;
            Debug.Log("name set to " + name);
        }
    }
}
