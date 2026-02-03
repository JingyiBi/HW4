using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 400f;
    public float deadZone = -15f;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale>0)
        {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
        }
    }
}

