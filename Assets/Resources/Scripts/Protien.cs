using UnityEngine;
using System.Collections;

public class Protien : MonoBehaviour {

    Color color;
    //Protien child;

    public void Initialize(Color _color)
    {
        color = _color;
        GetComponent<SpriteRenderer>().color = color;
    }

    void OnMouseDown()
    {
        GV.mainFlow.mouseFollow.toFollowMouse = this;
    }

    void OnMouseUp()
    {
        GV.mainFlow.mouseFollow.toFollowMouse = null;
        GV.mainFlow.mouseFollow.Throw(this);
    }

}
