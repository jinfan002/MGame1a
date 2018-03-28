using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removalfunc : MonoBehaviour {

    public int timeLeft = 4;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
       

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            Destroy(gameObject);
        }
        
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
