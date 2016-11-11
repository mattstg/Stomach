using UnityEngine;
using System.Collections;

public class MainFlow : MonoBehaviour {
    public MouseFollow mouseFollow = new MouseFollow();

    float counter = 0;

    public void Awake()
    {
        GV.mainFlow = this;
    }

    public void Update()
    {
        mouseFollow.Update();

        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            counter = GV.butthole_speed;
            ProtienFactory.Instance.CreateRandomProtien();
        }
    }
    
}
