using UnityEngine;


public class EndCheckpoint : MonoBehaviour
{
    public GameObject ThisCheckpoint;
    public GameObject TimePanel;
    public GameObject EndScreen;
  

    void OnTriggerEnter()
    {
        ThisCheckpoint.SetActive(false);
        TimePanel.SetActive(true);
        EndScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}


