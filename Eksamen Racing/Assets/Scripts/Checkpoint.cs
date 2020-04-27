using UnityEngine;


    public class Checkpoint : MonoBehaviour
    {
        public GameObject ThisCheckpoint;
        public GameObject NextCheckpoint;
    

        void OnTriggerEnter()
        {
            NextCheckpoint.SetActive(true);
            ThisCheckpoint.SetActive(false);
        }
    }

