
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class MojitoSO : ScriptableObject
{
    public List<int> _Ids = new List<int>();
    public float WhiteRumNeeded = 1;
    public int WhiteRumID;

    public float MintNeeded = 1;
    public int MintNeededID;

    public float LimeNeeded = 1;
    public int LimeNeededID;

    public float SpriteNeeded = 2;
    public int SpriteNeededID;
}
