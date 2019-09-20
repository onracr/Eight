using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScenePlayer : MonoBehaviour
{
    [SerializeField] new Camera camera;
    [Space(10)]
    public float moveSpeed = 0.05f;

    private void Start() 
    {
        camera.transform.position = this.transform.position;
    }

    private void Update() 
    {
        Movement();    
    }

    private void Movement()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }


}
