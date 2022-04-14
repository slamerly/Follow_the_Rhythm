using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassBeat : MonoBehaviour
{
    public bool playGoodTime = false;
    public bool playSweet = false;
    public bool loop = false;
    public float timeBeatGoodTime = 0.1f;
    public float timeBeatSweet = 0.1f;

    float diffBeatTempoGoodTime;
    float diffBeatTempoSweet;
    float tempoGoodTime;
    float tempoSweet;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
        tempoSweet = (60f / 98f) / 4f;
        tempoGoodTime = (60f / 96f) / 4f;
        timeBeatGoodTime = tempoGoodTime;
        timeBeatSweet = tempoSweet;
        diffBeatTempoSweet = tempoSweet - timeBeatSweet;
        diffBeatTempoGoodTime = tempoGoodTime - timeBeatGoodTime;

        gameObject.SetActive(false);
    }

    public IEnumerator PlayBassGoodTime()
    {
        if (loop)
        {
            while (true)
            {
                // Mesure 1
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);
                // Mesure 2
                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                // Mesure 3

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);
                // Mesure 4
                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                // Mesure 5

                yield return new WaitForSeconds(timeBeatGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);
                // Mesure 6
                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 5);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 7);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                // Mesure 7

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 5);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 7);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                // Mesure 8

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatGoodTime * 2);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);
            }
        }
        else
        {
            // Mesure 1
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);
            // Mesure 2
            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            // Mesure 3

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);
            // Mesure 4
            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            // Mesure 5

            yield return new WaitForSeconds(timeBeatGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);
            // Mesure 6
            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 5);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 7);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            // Mesure 7

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 5);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 7);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            // Mesure 8

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatGoodTime * 2);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoGoodTime + tempoGoodTime * 4);
        }
    }

    public IEnumerator PlayBassSweet()
    {
        if (loop)
        {
            while (true)
            {
                // Mesure 1
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 2
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 3
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 4
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 5
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 6
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 7
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

                // Mesure 8
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

                yield return new WaitForSeconds(timeBeatSweet);

                GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

                yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);
            }
        }
        else
        {
            // Mesure 1
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 2
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 3
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 4
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 5
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 6
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 7
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);

            // Mesure 8
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 9);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 3);

            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

            yield return new WaitForSeconds(timeBeatSweet);

            GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);

            yield return new WaitForSeconds(diffBeatTempoSweet + tempoSweet * 1);
        }
    }
}
