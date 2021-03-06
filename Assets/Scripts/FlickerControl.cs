using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{

    public bool isFlickering = false;
    public float timeDelay;
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(flickeringLight());
        }
    }

    IEnumerator flickeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 1f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 1f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }

}
