using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpSystem : MonoBehaviour
{
    [SerializeField] private Text dreamText;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [Space(8)]
    [SerializeField] private Notes notes;
    [SerializeField] private GameObject paperMenu, helperGui;     // helper <-> gui
    [SerializeField] private GameObject[] paperObjects;
    [SerializeField] private GameObject magicDoor;
    
    private int paperCounter = 0;
    private bool flag = true;
    private GameObject player;
    private object[] collections = new object[8];
    private Queue<GameObject> paperObjectsRef = new Queue<GameObject>();

    private void Start()
    {
        player = GameObject.Find("Player");
        //dreamText = GetComponent<Text>();
        collections = notes.AddingNotes();
        // To prevent array index error, copied all elements of paperObjects[] to a queue
        CopyToQueue(paperObjects);  
    }

    private void Update()
    {
        OpeningPaperMenu();
    }

    private void OnTriggerStay (Collider otherObject) 
    {
        if (otherObject.gameObject.layer == 9 ){
            helperGui.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)){
                helperGui.SetActive(false);
                flag = !flag;

                if (paperCounter == 3)
                    Destroy(paperMenu.transform.GetChild(3).gameObject);

                
                Destroy(otherObject.gameObject);
                PrintTextsToScreen();
                paperCounter++;

                if (paperObjectsRef.Count > 1){
                    paperObjectsRef.Dequeue();
                    paperObjectsRef.Peek().SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit() 
    {
        helperGui.SetActive(false);    
    }

    private void PrintTextsToScreen()
    {
        player.GetComponent<Player>().enabled = false;
        paperMenu.SetActive(true);

        if (collections[paperCounter] is string){
            spriteRenderer.enabled = false;
            dreamText.enabled = true;
            dreamText.text = collections[paperCounter].ToString();
        }
        else
        {
            dreamText.enabled = false;
            spriteRenderer.sprite = (Sprite) collections[paperCounter];
            spriteRenderer.enabled = true;
        }
    }

    private void OpeningPaperMenu()
    {
            if (Input.GetKeyDown(KeyCode.Q)){
                if (paperObjectsRef.Count == 1) {
                    magicDoor.GetComponent<Animator>().enabled = true;
                }
            player.GetComponent<Player>().enabled = !flag;
                paperMenu.SetActive(flag);
                flag = !flag;
            }
    }

    private void CopyToQueue(GameObject[] paperObjects)
    {
        foreach (var paper in paperObjects) {
            paperObjectsRef.Enqueue(paper);
        }
    }
}
