using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour{

    public GameObject lapCompleteTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public string minCount, secCount, milCount;
    public int milRounder;

    public Text PrintEndTimeDisplay;

    public void OnTriggerEnter() {
        milRounder = (int) LapTimeManager.MilliCount;
        
        if (LapTimeManager.SecondCount < 10){
            secCount = "0" + LapTimeManager.SecondCount;
        } else{
           secCount = "" + LapTimeManager.SecondCount;
        }

        if (LapTimeManager.MinuteCount < 10){
            minCount = "0" + LapTimeManager.MinuteCount;
        }
        else{
            minCount = "" + LapTimeManager.MinuteCount;
        }

        if (LapTimeManager.MilliCount < 10) {
            milCount = "0" + milRounder;
        } else {
            milCount = "" + milRounder;
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        PrintEndTimeDisplay.text = "Time: " + minCount + ":" + secCount + ":" + milCount;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        lapCompleteTrig.SetActive(false);
        Time.timeScale = 0f;
    }

}
