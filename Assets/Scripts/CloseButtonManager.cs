using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonManager : MonoBehaviour
{
    public void onPress() {
        MySceneManager.errorMessage = "Fatal Error: Attempted to exit program prematurely.  Crashing anyway.";
        MySceneManager.transitionToScene(SceneID.error);
    }
}
