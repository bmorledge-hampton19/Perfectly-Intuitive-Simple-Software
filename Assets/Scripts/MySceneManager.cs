using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneID
{
    error = 0,
    title = 1,
    register = 2,

}


public static class MySceneManager
{
    static Dictionary<SceneID,string> sceneIDToName = new Dictionary<SceneID, string>{
        {SceneID.error, "Error"},
        {SceneID.title, "Intro"},
        {SceneID.register, "Registration"},
    };
    public static void transitionToScene(SceneID sceneID) {
        SceneManager.LoadScene(sceneIDToName[sceneID], LoadSceneMode.Single);
    }

    public static string errorMessage;
    public static bool registered = false;
}
