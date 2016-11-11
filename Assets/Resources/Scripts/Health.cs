using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Health  {

    Dictionary<Color, float> balances;
    float hp;

    public Health()
    {
        balances = new Dictionary<Color, float>();
        hp = GV.hp_start;

        foreach (Color color in GV.activeColors)
            balances.Add(color, .5f);
    }
}
