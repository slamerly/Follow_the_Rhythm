using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject[] speakersL;
    GameObject[] speakersR;
    GameObject[] lightsDirectionL;
    GameObject[] lightsDirectionR;
    GameObject[] lightsDrumBeat;

    private void Awake()
    {
        speakersL = GameObject.FindGameObjectsWithTag("SpeakerL");
        speakersR = GameObject.FindGameObjectsWithTag("SpeakerR");
        lightsDirectionL = GameObject.FindGameObjectsWithTag("LightL");
        lightsDirectionR = GameObject.FindGameObjectsWithTag("LightR");
        lightsDrumBeat = GameObject.FindGameObjectsWithTag("DrumBeat");

        foreach (GameObject lightDirectionL in lightsDirectionL)
        {
            lightDirectionL.GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
            lightDirectionL.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        }
        foreach (GameObject lightDirectionR in lightsDirectionR)
        {
            lightDirectionR.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            lightDirectionR.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            //Debug.Log("hello");
            if (Input.GetKey(KeyCode.E))
            {
                //Debug.Log("laterre");
                if (CompareTag("ButtonL")) {
                    foreach (GameObject speakerR in speakersR)
                    {
                        if (speakerR.transform.parent.name == transform.parent.name)
                        {
                            speakerR.GetComponent<AudioSource>().Stop();
                            foreach (GameObject lightDirectionR in lightsDirectionR)
                            {
                                Debug.Log(lightDirectionR.transform.parent.parent.name);
                                if (lightDirectionR.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionR.GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                                    lightDirectionR.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
                                }
                            }
                        }
                    }
                    foreach (GameObject speakerL in speakersL)
                    {
                        if (speakerL.transform.parent.name == transform.parent.name)
                        {
                            speakerL.GetComponent<AudioSource>().Play();
                            foreach(GameObject lightDirectionL in lightsDirectionL)
                            {
                                Debug.Log(lightDirectionL.transform.parent.parent.name);
                                if (lightDirectionL.transform.parent.parent.name == transform.parent.name)
                                { 
                                    lightDirectionL.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
                                    lightDirectionL.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
                                }
                            }
                            foreach(GameObject light in lightsDrumBeat)
                            {
                                if (light.transform.parent.name == transform.parent.name && light.transform.name == "LightBeatDrumGood")
                                {
                                    StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                                }
                            }
                        }
                    }
                }
                if (CompareTag("ButtonR"))
                {
                    foreach (GameObject speakerL in speakersL)
                    {
                        if (speakerL.transform.parent.name == transform.parent.name)
                        {
                            speakerL.GetComponent<AudioSource>().Stop();
                            foreach (GameObject lightDirectionL in lightsDirectionL)
                            {
                                Debug.Log(lightDirectionL.transform.parent.parent.name);
                                if (lightDirectionL.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionL.GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
                                    lightDirectionL.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
                                }
                            }
                        }
                    }
                    foreach (GameObject speakerR in speakersR)
                    {
                        if (speakerR.transform.parent.name == transform.parent.name)
                        {
                            speakerR.GetComponent<AudioSource>().Play();
                            foreach (GameObject lightDirectionR in lightsDirectionR)
                            {
                                Debug.Log(lightDirectionR.transform.parent.parent.name);
                                if (lightDirectionR.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionR.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
                                    lightDirectionR.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
