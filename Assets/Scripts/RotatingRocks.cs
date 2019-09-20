using UnityEngine;

public class RotatingRocks : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float risingSpeed = 0.05f;
    public float requiredHeight = -23.36f;
    
    private bool flag = false;
    private int childCount1 = 0;
    private Vector3 startingLocation;
    private Transform[] childTransform = new Transform[20];

    void Start() 
    {
        startingLocation = transform.position;
        GetChildren();
    }

    private void Update() 
    {
        if (flag){
            if (transform.position.y > startingLocation.y)
                transform.Translate(Vector3.down * risingSpeed * Time.deltaTime, Space.Self);

            for (int i = 0; i < childTransform.Length; i++)
                childTransform[i].Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }     
    }

    private void OnTriggerStay(Collider other) 
    {
        if (transform.position.y < requiredHeight)
            transform.Translate(Vector3.up * risingSpeed * Time.deltaTime, Space.Self);

        for (int i = 0; i < childTransform.Length; i++)
            childTransform[i].Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other) 
    {
        flag = true;
    }

    private void GetChildren()
    {
        childCount1 = transform.GetChild(0).transform.childCount;
        for (int i = 0 ; i < childCount1; i++)
            childTransform[i] = transform.GetChild(0).transform.GetChild(i);
    }

}
