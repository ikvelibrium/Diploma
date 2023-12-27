
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class MojitoSO : ScriptableObject
{
    public string OrderName;
    public List<int> _Ids = new List<int>();
    
}
