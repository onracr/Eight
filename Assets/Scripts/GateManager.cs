using UnityEngine;

public class GateManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();    
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip);
    }
    
}
