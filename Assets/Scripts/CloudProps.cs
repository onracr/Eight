using UnityEngine;

public class CloudProps : MonoBehaviour
{
    [SerializeField] Light sun = null;
    [SerializeField] Light moon = null;
    [SerializeField] [Range (0f, 150f)] private float cloudEmission = 151f;
    private ParticleSystem dynamicClouds;

    private float timer = 10.0f;
    private float cloudIntensityRate = 30.0f;

    void Start()
    {
        dynamicClouds = GetComponent<ParticleSystem>();
        InvokeRepeating("CloudIntensity", timer, cloudIntensityRate);
    }

    void Update()
    {
        moon.transform.rotation *= Quaternion.Euler(10f,0,0);
        // moon.transform.Rotate(10f, 0f, 0f, Space.Self);  2nd option 
        var main = dynamicClouds.main;
        if (sun.transform.rotation.x < moon.transform.rotation.x)   
        {
            main.startColor = new Color(0.06f, 0.06f, 0.06f, 1f);
            RenderSettings.fogColor = new Color(0.06f, 0.06f, 0.06f, 1f);   // changes the fog color during day and night
        }
        else 
        {
            main.startColor = new Color(0.46f, 0.46f, 0.461f, 1f);
            RenderSettings.fogColor = new Color(0.35f, 0.349f, 0.30f, 1f);
        }

        CloudIntensity();
    }

    private void CloudIntensity()
    {
            var emission = dynamicClouds.emission;
            emission.rateOverTime = Random.Range(0f, cloudEmission);
    }
}
