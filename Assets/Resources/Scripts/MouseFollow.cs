using UnityEngine;
using System.Collections;

public class MouseFollow   {

    public Protien toFollowMouse;
    Vector3 lastMousePos = new Vector3();
    private Vector2 speed;
    float speedMult = 10;

    public void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0;
        speed = newPos - lastMousePos;        
        
        if (toFollowMouse)
            toFollowMouse.transform.position = newPos;

        lastMousePos = newPos;
    }

    public void Throw(Protien toThrow)
    {
        toThrow.GetComponent<Rigidbody2D>().velocity = speed * speedMult;
    }
}
