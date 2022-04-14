using UnityEngine;

public class CorridorEnter : MonoBehaviour
{
    GameObject[] speakersL;
    GameObject[] speakersR;
    GameObject[] speakersCorridorL;
    GameObject[] speakersCorridorR;
    GameObject[] lightsDrumBeat;

    private void Awake()
    {
        speakersL = GameObject.FindGameObjectsWithTag("SpeakerL");
        speakersR = GameObject.FindGameObjectsWithTag("SpeakerR");
        speakersCorridorL = GameObject.FindGameObjectsWithTag("SpeakerCorridorL");
        speakersCorridorR = GameObject.FindGameObjectsWithTag("SpeakerCorridorR");
        lightsDrumBeat = GameObject.FindGameObjectsWithTag("DrumBeat");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject speakerL in speakersL)
                speakerL.GetComponent<AudioSource>().Stop();
            foreach (GameObject speakerR in speakersR)
                speakerR.GetComponent<AudioSource>().Stop();

            if (CompareTag("CorridorL"))
            {
                foreach (GameObject speaker in speakersCorridorR)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Stop();
                }
                foreach (GameObject light in lightsDrumBeat)
                {
                    light.GetComponent<DrumBeat>().loop = false;
                    light.SetActive(false);
                }
                foreach (GameObject speaker in speakersCorridorL)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Play();
                }
                foreach (GameObject light in lightsDrumBeat)
                {
                    if (light.transform.parent.parent.name == transform.parent.name)
                    {
                        if (light.transform.parent.name == "CorridorL")
                        {
                            if (light.transform.name == "LightBeatDrumGood")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                            }
                            if (light.transform.name == "LightBeatDrumSweet")
                            {
                                light.SetActive(true);
                                light.GetComponent<DrumBeat>().loop = true;
                                StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                            }
                        }
                    }
                }
            }
            if (CompareTag("CorridorR"))
            {
                foreach (GameObject speaker in speakersCorridorL)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Stop();
                }
                foreach (GameObject light in lightsDrumBeat)
                {
                    light.GetComponent<DrumBeat>().loop = false;
                    light.SetActive(false);
                }
                foreach (GameObject speaker in speakersCorridorR)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Play();
                }
                foreach (GameObject light in lightsDrumBeat)
                {
                    if (light.transform.parent.parent.name == transform.parent.name)
                    {
                        if (light.transform.parent.name == "CorridorR")
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
