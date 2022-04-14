using System.Collections;
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
    }
    private void Start()
    {
        foreach (GameObject lightDirectionL in lightsDirectionL)
        {
            lightDirectionL.SetActive(false);
        }
        foreach (GameObject lightDirectionR in lightsDirectionR)
        {
            lightDirectionR.SetActive(false);
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
                                //Debug.Log(lightDirectionR.transform.parent.parent.name);
                                if (lightDirectionR.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionR.SetActive(false);
                                }
                            }
                            foreach (GameObject light in lightsDrumBeat)
                            {
                                if (light.transform.parent.name == transform.parent.name)
                                {
                                    //StopCoroutine(coroutineDrumBeatSweet);
                                    //StopAllCoroutines();
                                    light.SetActive(false);
                                }
                            }
                        }
                        //StopAllCoroutines();
                    }
                    foreach (GameObject speakerL in speakersL)
                    {
                        if (speakerL.transform.parent.name == transform.parent.name)
                        {
                            speakerL.GetComponent<AudioSource>().Play();
                            foreach(GameObject lightDirectionL in lightsDirectionL)
                            {
                                //Debug.Log(lightDirectionL.transform.parent.parent.name);
                                if (lightDirectionL.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionL.SetActive(true);
                                }
                            }
                            foreach(GameObject light in lightsDrumBeat)
                            {

                                if (light.transform.parent.name == transform.parent.name && light.transform.name == "LightBeatDrumGood")
                                {
                                    light.SetActive(true);
                                    StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                                }
                                else if(light.transform.parent.name == transform.parent.name && transform.parent.name != "RoomStart")
                                {
                                    if (light.transform.name == "LightBeatDrumGood")
                                    {
                                        light.SetActive(true);
                                        StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                                    }
                                    if (light.transform.name == "LightBeatDrumSweet")
                                    {
                                        light.SetActive(true);
                                        StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                                    }
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
                                //Debug.Log(lightDirectionL.transform.parent.parent.name);
                                if (lightDirectionL.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionL.SetActive(false);
                                }
                            }
                            foreach (GameObject light in lightsDrumBeat)
                            {
                                if (light.transform.parent.name == transform.parent.name)
                                {
                                    //StopCoroutine(coroutineDrumBeatGoodTime);
                                    StopAllCoroutines();
                                    light.SetActive(false);
                                }
                            }
                        }
                        //StopAllCoroutines();
                    }
                    foreach (GameObject speakerR in speakersR)
                    {
                        if (speakerR.transform.parent.name == transform.parent.name)
                        {
                            speakerR.GetComponent<AudioSource>().Play();
                            foreach (GameObject lightDirectionR in lightsDirectionR)
                            {
                                //Debug.Log(lightDirectionR.transform.parent.parent.name);
                                if (lightDirectionR.transform.parent.parent.name == transform.parent.name)
                                {
                                    lightDirectionR.SetActive(true);
                                }
                            }
                            foreach (GameObject light in lightsDrumBeat)
                            {
                                if (light.transform.parent.name == transform.parent.name && light.transform.name == "LightBeatDrumSweet")
                                {
                                    light.SetActive(true);
                                    StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                                }
                                else if(light.transform.parent.name == transform.parent.name && transform.parent.name != "RoomStart")
                                {
                                    if (light.transform.name == "LightBeatDrumGood")
                                    {
                                        light.SetActive(true);
                                        StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumGoodTime());
                                    }
                                    if (light.transform.name == "LightBeatDrumSweet")
                                    {
                                        light.SetActive(true);
                                        StartCoroutine(light.GetComponent<DrumBeat>().PlayDrumSweet());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
