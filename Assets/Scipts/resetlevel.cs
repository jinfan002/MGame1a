using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetlevelg : MonoBehaviour {

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel); // loads current scene
    }
}
