using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public static SoundManagement instance;

    [Header("Audio")]
    public AudioClip biting;
    public AudioClip UIClick, deniedClick;
    public AudioClip[] UIClicks;
    
    public AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UIClicking()
    {
        int index = Random.Range(0, UIClicks.Length);
        UIClick = UIClicks[index];

        audioSource.clip = UIClick;
        audioSource.Play();
    }

    public void BitingSound()
    {
        audioSource.clip = biting;
        audioSource.Play();
    }

    public void Denied()
    {
        audioSource.clip = deniedClick;
        audioSource.Play();
    }
}
