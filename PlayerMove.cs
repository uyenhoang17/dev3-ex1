using System.Globalization;
using UnityEngine;

public class PlayerMove : MonoBehavior
{
    
    public int speed = 10;
    
    void Start()
    {
    }


    void Update()
    {
        float xPos = Input.GetAxis("Horizontal") * speed;
        Vector3 pos = transform.position;
        pos.x += Time.deltaTime * xSpeed;
        transform.position = pos;
    }
    


}