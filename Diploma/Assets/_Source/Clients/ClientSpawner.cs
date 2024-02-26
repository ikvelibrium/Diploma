using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawner : MonoBehaviour
{
    [SerializeField] private List<MojitoSO> _drinks = new List<MojitoSO>();
    public MIxSyst mixSyst;
    
    public void SpawnRandomOrder()
    {   
        mixSyst.AddDrinkInOrder(_drinks[Random.Range(0, _drinks.Count)]);
    }

}
