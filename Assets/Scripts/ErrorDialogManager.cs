using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ErrorDialogManager : MonoBehaviour
{

    public TextMeshProUGUI errorMessage;

    // Start is called before the first frame update
    void Start()
    {
        errorMessage.text = MySceneManager.errorMessage;
    }

    public void reset() {
        MySceneManager.transitionToScene(SceneID.title);
    }
}
