using UnityEngine;

public class Button : MonoBehaviour
{
    //public GameObject speakerL;
    //public GameObject speakerR;


    //GameObject[] buttonsL;
    //GameObject[] buttonsR;
    GameObject[] speakersL;
    GameObject[] speakersR;

    private void Awake()
    {
        //buttonsL = GameObject.FindGameObjectsWithTag("ButtonL");
        //buttonsR = GameObject.FindGameObjectsWithTag("ButtonR");
        speakersL = GameObject.FindGameObjectsWithTag("SpeakerL");
        speakersR = GameObject.FindGameObjectsWithTag("SpeakerR");
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            //Debug.Log("hello");
            if (Input.GetKey(KeyCode.E))
            {
                //play = true;
                //Debug.Log("laterre");
                if (CompareTag("ButtonL")) {
                    foreach (GameObject speakerR in speakersR)
                    {
                        if(speakerR.transform.parent.name == transform.parent.name)
                            speakerR.GetComponent<AudioSource>().Stop();
                    }
                    foreach (GameObject speakerL in speakersL)
                    {
                        if (speakerL.transform.parent.name == transform.parent.name)
                            speakerL.GetComponent<AudioSource>().Play();
                    }
                }
                if (CompareTag("ButtonR"))
                {
                    foreach (GameObject speakerL in speakersL)
                    {
                        if (speakerL.transform.parent.name == transform.parent.name)
                            speakerL.GetComponent<AudioSource>().Stop();
                    }
                    foreach (GameObject speakerR in speakersR)
                    {
                        if (speakerR.transform.parent.name == transform.parent.name)
                            speakerR.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }
    }
}
