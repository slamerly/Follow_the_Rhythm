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
    List<string> validCorridor = new List<string>();

    private void Awake()
    {
        speakersCorridorL = GameObject.FindGameObjectsWithTag("SpeakerCorridorL");
        speakersCorridorR = GameObject.FindGameObjectsWithTag("SpeakerCorridorR");
    }

    private bool CorridorIsValid()
    {
        string saveString = null;
        foreach (string sub in validCorridor)
        {
            Debug.Log(validCorridor.Count);
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
                            speaker.GetComponent<AudioSource>().Stop();
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
                }
                if (CompareTag("CorridorR"))
                {
                    foreach (GameObject speaker in speakersCorridorR)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                        {
                            speaker.GetComponent<AudioSource>().Stop();
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
                }
                if (CompareTag("CorridorR"))
                {
                    foreach (GameObject speaker in speakersCorridorR)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                            speaker.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }
    }
}
