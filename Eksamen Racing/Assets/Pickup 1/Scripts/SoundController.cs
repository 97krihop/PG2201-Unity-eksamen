using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class SoundController : MonoBehaviour {
    public InputManager im;
    public AudioSource aSource;
    
    // Start is called before the first frame update
    void Start() {
        im = GetComponent<InputManager>();       
        aSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        float pitchValue = im.throttle;

        if(pitchValue == 0) {
            aSource.GetComponent<AudioSource>().pitch = 0.4F;  
        } else if (pitchValue == 1) {
            aSource.GetComponent<AudioSource>().pitch = 0.8F;  
        } else {
            aSource.GetComponent<AudioSource>().pitch = pitchValue;  
        }
    }

}