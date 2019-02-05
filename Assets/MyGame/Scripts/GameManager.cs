using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    public enum SingletonTypes
    {
        SINGLETONSIMPLE = 0,
        SINGLETONFIX1 = 1,
        SINGLETONFIX2AND3 = 2,
        SINGLETONFIX4 = 3,
    }

    
    public SingletonTypes singletonType = 0;

    private InputField objName;
    private TextMeshProUGUI tmproName;

    public SceneLoader sceneLoader;

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
        //        tmproName.text = SingletonControllerFixIssue4.Instance.Name;
                
        //        break;

        //}
    }


    private void Start()
    {
        

        objName = FindObjectOfType<InputField>();

    }

    public void SaveName()
    {
        //SingletonControllerFixIssue4.Instance.Name =  objName.text;
        SingletonController.instance.Name = objName.text;
        sceneLoader.LoadNextScene();
    }

    public void LoadName()
    {
        if(tmproName == null)
        {
            tmproName = GameObject.Find("TMPName").GetComponent<TextMeshProUGUI>();
        }

        //tmproName.text = SingletonControllerFixIssue4.Instance.Name;
        tmproName.text = SingletonController.instance.Name;
        //switch (singletonType)
        //{
        //    case SingletonTypes.SINGLETONSIMPLE:
        //        Debug.Log("Singleton simple is choosen");
        //        break;
        //    case SingletonTypes.SINGLETONFIX4:
        //        Debug.Log("Singleton FIX4 is choosen");
        //        tmproName.text = SingletonControllerFixIssue4.Instance.Name;
        //        break;

        //}
    }
}
