using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] float dayLength = 5f;


    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, dayLength * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }

    public void SetDayLength(float dayLength)
    {
        this.dayLength = dayLength;
    }
}
