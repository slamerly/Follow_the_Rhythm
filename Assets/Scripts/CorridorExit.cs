using System.Collections.Generic;
using UnityEngine;

public class CorridorExit : MonoBehaviour
{
    public GameObject wall;
    public bool loose = false;
    public bool win = false;

    bool cross = false;
    GameObject[] speakersCorridorL;
    GameObject[] speakersCorridorR;
    GameObject[] lightsDrumBeat;
    List<string> validCorridor = new List<string>();

    private void Awake()
    {
        speakersCorridorL = GameObject.FindGameObjectsWithTag("SpeakerCorridorL");
        speakersCorridorR = GameObject.FindGameObjectsWithTag("SpeakerCorridorR");
        lightsDrumBeat = GameObject.FindGameObjectsWithTag("DrumBeat");
    }

    private bool CorridorIsValid()
    {
        string saveString = null;
        foreach (string sub in validCorridor)
        {
            if (saveString != null && saveString != sub)
            {
                return false;
            }
            saveString = sub;
        }
        return true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!cross)
            {
                cross = true;
                if (CompareTag("CorridorL"))
                {
                    foreach (GameObject speaker in speakersCorridorL)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                        {
                            //speaker.GetComponent<AudioSource>().Stop();
                            string[] subsName = speaker.GetComponent<AudioSource>().clip.name.Split(char.Parse("_"));
                            foreach (string sub in subsName)
                            {
                                if (sub == "Sweet" || sub == "Good")
                                    validCorridor.Add(sub);
                            }
                            if (!CorridorIsValid())
                                loose = true;
                            if (CorridorIsValid() && validCorridor.Count == 4)
                            {
                                win = true;
                            }
                        }
                    }
                    if (!win)
                    {
                        foreach (GameObject speaker in speakersCorridorL)
                        {
                            if (speaker.transform.parent.name == transform.parent.name)
                            {
                                speaker.GetComponent<AudioSource>().Stop();
                            }
                        }
                        foreach (GameObject light in lightsDrumBeat)
                        {
                            light.GetComponent<DrumBeat>().loop = false;
                            light.SetActive(false);
                        }
                    }
                }
                if (CompareTag("CorridorR"))
                {
                    foreach (GameObject speaker in speakersCorridorR)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                        {
                            //speaker.GetComponent<AudioSource>().Stop();
                            string[] subsName = speaker.GetComponent<AudioSource>().clip.name.Split(char.Parse("_"));
                            foreach (string sub in subsName)
                            {
                                if (sub == "Sweet" || sub == "Good")
                                    validCorridor.Add(sub);
                            }
                            if (!CorridorIsValid())
                                loose = true;
                            if (CorridorIsValid() && validCorridor.Count == 4)
                                win = true;
                        }
                    }
                    if (!win)
                    {
                        foreach (GameObject speaker in speakersCorridorR)
                        {
                            if (speaker.transform.parent.name == transform.parent.name)
                            {
                                speaker.GetComponent<AudioSource>().Stop();
                            }
                        }
                        foreach (GameObject light in lightsDrumBeat)
                        {
                            light.GetComponent<DrumBeat>().loop = false;
                            light.SetActive(false);
                        }
                    }
                }
                wall.SetActive(true);
            }
            else
            {
                cross = false;
                if (CompareTag("CorridorL"))
                {
                    foreach (GameObject speaker in speakersCorridorL)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                            speaker.GetComponent<AudioSource>().Play();
                    }
                    foreach (GameObject light in lightsDrumBeat)
                    {
                        //if (light.transform.parent.parent.name == transform.parent.name && light.transform.name == "LightBeatDrumGood")
                        if (light.transform.parent.parent.parent.name == transform.parent.name)
                        {
                            if (light.transform.name == "LightBeatDrumGood")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                            }
                            if(light.transform.name == "LightBeatDrumSweet")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                            }
                        }
                    }
                }
                if (CompareTag("CorridorR"))
                {
                    foreach (GameObject speaker in speakersCorridorR)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                            speaker.GetComponent<AudioSource>().Play();
                    }
                    foreach (GameObject light in lightsDrumBeat)
                    {
                        //if (light.transform.parent.parent.name == transform.parent.name && light.transform.name == "LightBeatDrumSweet")
                        if (light.transform.parent.parent.parent.name == transform.parent.name)
                        {
                            if (light.transform.name == "LightBeatDrumSweet")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                            }
                            if (light.transform.name == "LightBeatDrumGood")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                            }
                        }
                    }
                }
            }
        }
    }
}
