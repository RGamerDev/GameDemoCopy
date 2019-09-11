using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] Pos;
    public int SIndx;
    public int coins;

    public PlayerData(MainScript Main)
    {
        SIndx = Main.SIndx;

        Pos = new float[3];
        Pos[0] = Main.CurrentPos.x;
        Pos[1] = Main.CurrentPos.y;
        Pos[2] = Main.CurrentPos.z;

        coins = MainScript.Coins;
    }

    public PlayerData(TutorialScript TScript)
    {
        SIndx = TScript.SIndx;

        Pos = new float[3];
        Pos[0] = TScript.CurrentPos.x;
        Pos[1] = TScript.CurrentPos.y;
        Pos[2] = TScript.CurrentPos.z;
    }
}
