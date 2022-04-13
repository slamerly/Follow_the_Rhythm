using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        StartCoroutine(PlayDrumGoodTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayDrumGoodTime()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        yield return new WaitForSeconds(3.2f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);

        yield return new WaitForSeconds(2.4f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
    } 
}
