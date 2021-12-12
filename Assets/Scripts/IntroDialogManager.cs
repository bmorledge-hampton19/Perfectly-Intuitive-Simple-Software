using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroDialogManager : MonoBehaviour
{

    public List<TextMeshProUGUI> titleTexts;
    private int currentlyRevealingIndex;
    private float fillRate;

    // Start is called before the first frame update
    void Start()
    {
        resetText();
        decideHowCursedTheTitleAnimationIs();
    }

    void resetText() {
        foreach(TextMeshProUGUI titleText in titleTexts) {
            titleText.alpha = 0;
        }
        currentlyRevealingIndex = 0;
    }

    void decideHowCursedTheTitleAnimationIs() {
        int rollTheDice = Random.Range(0, 10);
        if (rollTheDice == 0) fillRate = 0.2f;
        else if (rollTheDice == 9) fillRate = 5f;
        else fillRate = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentlyRevealingIndex == 5) return;

        float alpha = titleTexts[currentlyRevealingIndex].alpha;
        if(alpha >= 1) currentlyRevealingIndex += 1;
        else {
            alpha += Time.deltaTime*fillRate;
            titleTexts[currentlyRevealingIndex].alpha = alpha;
        }

    }

    public void onBegin() {
        if (currentlyRevealingIndex == 5) MySceneManager.transitionToScene(SceneID.register);
        else {
            MySceneManager.errorMessage = "Fatal Error: Disrespect of software moniker detected.  Terminating.";
            MySceneManager.transitionToScene(SceneID.error);
        }
    }

}
