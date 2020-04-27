using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour{

    public GameObject lapCompleteTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    void OnTriggerEnter(){
        
        if (LapTimeManager.SecondCount <= 9){
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        } else{
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9){
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else{
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;


        lapCompleteTrig.SetActive(false);
        Time.timeScale = 0f;

    }

}
