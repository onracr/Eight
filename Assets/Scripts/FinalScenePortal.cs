using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScenePortal : MonoBehaviour
{
    private Image img;
    
    public string sceneName;
    public GameObject blackImg;
    public AudioSource[] sources;

    private void Start() {
        img = blackImg.GetComponent<Image>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")){
            GameObject.Find("Player").GetComponent<Player>().enabled = false;
            StartCoroutine(FinalSceneAnimation());
        }    
    }

    IEnumerator FinalSceneAnimation()
    {
        blackImg.SetActive(true);

        for (int i = 0; i < sources.Length; i++){
            while (sources[i].volume > 0.01f){
                sources[i].volume -= Time.deltaTime / 1.0f;
                yield return null;
            }
        }

        yield return new WaitUntil(()=> img.color.a == 1);
        SceneManager.LoadScene(sceneName);
    }

}
