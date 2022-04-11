using UnityEngine;

public class CorridorExit : MonoBehaviour
{
    public GameObject wall;

    bool cross = false;
    GameObject[] speakersCorridorL;
    GameObject[] speakersCorridorR;

    private void Awake()
    {
        speakersCorridorL = GameObject.FindGameObjectsWithTag("SpeakerCorridorL");
        speakersCorridorR = GameObject.FindGameObjectsWithTag("SpeakerCorridorR");
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
                            speaker.GetComponent<AudioSource>().Stop();
                    }
                }
                if (CompareTag("CorridorR"))
                {
                    foreach (GameObject speaker in speakersCorridorR)
                    {
                        if (speaker.transform.parent.name == transform.parent.name)
                            speaker.GetComponent<AudioSource>().Stop();
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
