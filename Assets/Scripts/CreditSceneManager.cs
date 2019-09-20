using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSceneManager : MonoBehaviour
{
    public GameObject fadeOutImg;
    public AudioSource source;
    public string sceneName;

    private void Update()
    {
        if (source.time >= 200f)
            fadeOutImg.SetActive(true);

        if (!source.isPlaying)
            SceneManager.LoadScene(sceneName);
    }

}
