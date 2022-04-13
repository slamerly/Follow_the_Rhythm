using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumBeat : MonoBehaviour
{
    public bool playGoodTime = false;
    public bool playSweet = false;
    public bool loop = false;
    public float timeBeat = 0.2f;

    float diffBeatTempoGoodTime;
    float diffBeatTempoSweet;
    float tempoGoodTime;
    float tempoSweet;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
        tempoSweet = (98f / 60f) / 4f;
        tempoGoodTime = (96f / 60f) / 4f;
        diffBeatTempoSweet = tempoSweet - timeBeat;
        diffBeatTempoGoodTime = tempoGoodTime - timeBeat;

        StartCoroutine(PlayDrumSweet());
    }

    private void Update()
    {
        do
        {
            if (playGoodTime)
                StartCoroutine(PlayDrumGoodTime());
            if (playSweet)
                StartCoroutine(PlayDrumSweet());
        } while (loop);
    }

    IEnumerator PlayDrumGoodTime()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(3.2f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(2.4f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(0.8f);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
    }

    IEnumerator PlayDrumSweet()
    {
        // Mesure 1
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet*9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 2
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 3
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 4
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 5
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 6
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 7
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

        // Mesure 8
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        yield return new WaitForSeconds(timeBeat);

        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

        yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

    }
}
