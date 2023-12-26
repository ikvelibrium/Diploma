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
        switch (_ingridient.ID) 
        {
            case 0 : WhiteRumPicked();
                break;
            case 1 : SpritePicked(); 
                break;
            case 2 : LimePicked();
                break;
            case 3 : MintPicked();
                break;
        }
    }

    public void WhiteRumPicked() // 0
    {
        mIxSyst.AddInDrink(0);
    }

    public void SpritePicked() // 1
    {
        mIxSyst.AddInDrink(1);

    }   

    public void LimePicked() // 2
    {
        mIxSyst.AddInDrink(2);
    }

    public void MintPicked() // 3
    {
        mIxSyst.AddInDrink(3);
    }
}
