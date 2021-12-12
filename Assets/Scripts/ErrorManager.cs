using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorManager : MonoBehaviour
{

    public UnityEngine.GameObject errorDialogPrefab;
    private int initializedErrorUIs;
    private int maxErrorMessages;
    private float timeSinceLastError;

    // Start is called before the first frame update
    void Start()
    {
        initializedErrorUIs = 0;
        timeSinceLastError = 1000;
        if (Random.Range(0,20) == 0) maxErrorMessages = 100;
        else maxErrorMessages = Random.Range(10,21);
    }

    void Update() {

        if (initializedErrorUIs == maxErrorMessages) return;

        timeSinceLastError += Time.deltaTime;
        if (timeSinceLastError > 0.25) {

            var errorDialog = Instantiate(errorDialogPrefab);
            errorDialog.transform.SetParent(transform, false);

            var parentRect = GetComponent<RectTransform>().rect;
            var childRect = errorDialog.GetComponent<RectTransform>().rect;
            float xWiggleRoom = (parentRect.width - childRect.width) / 2;
            float yWiggleRoom = (parentRect.height - childRect.height) / 2;

            errorDialog.transform.localPosition = new Vector2(Random.Range(-xWiggleRoom,xWiggleRoom), 
                                                              Random.Range(-yWiggleRoom,yWiggleRoom));

            timeSinceLastError = 0;
            initializedErrorUIs += 1;                                                  
        }

    }

}
