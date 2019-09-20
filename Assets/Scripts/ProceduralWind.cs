using UnityEngine;

public class ProceduralWind : MonoBehaviour
{
    private WindZone windZone = null;
    private AudioSource windSound = null;

    private float timer = 10f;
    private float changeRate = 10f;

    float fadeTime = 0.001f;

    void Start()
    {
        windZone = GetComponent<WindZone>();    
        windSound = GetComponent<AudioSource>();

        InvokeRepeating("WindIntensity", timer, changeRate);
    }

    private void WindIntensity()
    {
        float randomValue = Random.Range(0f, 1.0f);
        if (randomValue > windZone.windMain && randomValue <= windSound.volume){
            windZone.windMain = randomValue / 2;
            windSound.volume = randomValue;
        }
    }
}
