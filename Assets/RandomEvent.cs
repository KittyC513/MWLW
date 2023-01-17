using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomEvent : MonoBehaviour
{
    public GameObject randEvent;
    public GameObject privateChat;
    public GameObject effectA;
    public GameObject effectB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RandomEvents()
    {
        randEvent.SetActive(true);
    }

    public void RemoveRandomEvents()
    {
        randEvent.SetActive(false);
    }

    public void PrivateChat()
    {
        privateChat.SetActive(true);
    }

    public void RemovePrivateChat()
    {
        privateChat.SetActive(false);
    }

    public void EffectA()
    {
        effectA.SetActive(true);
    }

    public void EffectB()
    {
        effectB.SetActive(true);
    }

    public void RemoveEffectA()
    {
        effectA.SetActive(false);
    }

    public void RemoveEffectB()
    {
        effectB.SetActive(false);
    }

}
