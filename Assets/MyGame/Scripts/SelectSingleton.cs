using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSingleton : MonoBehaviour {

    public enum SingletonTypes
    {
        SINGLETONSIMPLE = 0,
        SINGLETONFIX1 = 1,
        SINGLETONFIX2AND3 = 2,
        SINGLETONFIX4 = 3,
    }

    private void Awake()
    {
        //switch (singletonType)
        //{
        //    case SingletonTypes.SINGLETONSIMPLE:
        //        Debug.Log("Singleton simple is choosen");
        //        //SingletonControllerFixIssue4.Instance.gameObject.SetActive(false);
        //        SingletonController.instance.gameObject.SetActive(true);
        //        break;
        //    case SingletonTypes.SINGLETONFIX4:
        //        Debug.Log("Singleton FIX4 is choosen");
        //        SingletonControllerFixIssue4.Instance.gameObject.SetActive(true);
        //        SingletonController.instance.gameObject.SetActive(false);
               

        //        break;

        //}
    }
}
