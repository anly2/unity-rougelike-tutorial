using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {
    public GameObject gameManager;
    public GameObject soundManager;

    void Awake ()
    {
        //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
        if (GameManager.instance == null)
            Instantiate(gameManager);
    }
}
