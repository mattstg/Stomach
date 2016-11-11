using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProtienFactory
{

    #region ProtienFactory
    private static ProtienFactory instance;

    private ProtienFactory() { }

    public static ProtienFactory Instance
    {
        get{
            if(instance == null)
            {
                instance = new ProtienFactory();
            }
            return instance;
        }
    }
#endregion

    float startVeloSpeed = 2;
    

    public Protien CreateRandomProtien()
    {
        GameObject go = MonoBehaviour.Instantiate(Resources.Load("Prefabs/Protien")) as GameObject;
        Vector2 startVelo = new Vector2(Random.Range(-1f * startVeloSpeed, startVeloSpeed), Random.Range(-1f * startVeloSpeed, startVeloSpeed));
        go.GetComponent<Rigidbody2D>().velocity = startVelo;

        Protien toRet = go.GetComponent<Protien>();
        Color color = GV.activeColors[Random.Range(0,GV.activeColors.Count)];
        toRet.Initialize(color);
        return toRet;
    }
}
