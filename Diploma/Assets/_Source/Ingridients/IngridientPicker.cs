using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngridientPicker : MonoBehaviour
{
    [SerializeField] private MIxSyst mIxSyst;
    [SerializeField] private int _ingridentsInGameAmount;
    private Ingridient _ingridient; 
    public void DefineWhatPicked(GameObject ingridient)
    {
        _ingridient = ingridient.GetComponent<Ingridient>();

        IngridientPicked(_ingridient.ID);
     
    }

    public void IngridientPicked(int id)
    {
        mIxSyst.AddInDrink(id);
    }
}
