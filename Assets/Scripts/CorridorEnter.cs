using UnityEngine;

public class CorridorEnter : MonoBehaviour
{
    GameObject[] speakersL;
    GameObject[] speakersR;
    GameObject[] speakersCorridorL;
    GameObject[] speakersCorridorR;

    private void Awake()
    {
        speakersL = GameObject.FindGameObjectsWithTag("SpeakerL");
        speakersR = GameObject.FindGameObjectsWithTag("SpeakerR");
        speakersCorridorL = GameObject.FindGameObjectsWithTag("SpeakerCorridorL");
        speakersCorridorR = GameObject.FindGameObjectsWithTag("SpeakerCorridorR");
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
                foreach (GameObject speaker in speakersCorridorL)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Play();
                }
            }
            if (CompareTag("CorridorR"))
            {
                foreach (GameObject speaker in speakersCorridorL)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Stop();
                }
                foreach (GameObject speaker in speakersCorridorR)
                {
                    if (speaker.transform.parent.name == transform.parent.name)
                        speaker.GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
