using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MIxSyst : MonoBehaviour
{
    [SerializeField] private Image _Glass;
    [SerializeField] private MojitoSO _firstOrderSO;
    [SerializeField] private ScriptableObject _secondOrderSO;
    [SerializeField] private ScriptableObject _thirdOrderSO;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _looseScreen;
   public  List<int> ingrideentsID = new List<int>();
    
    
    private float _maxDrinkVolume = 100;
    private float _curentDrinkVolume = 0;

    private bool _isRecepyGood;
    private int _counter = 0;

    private void Update()
    {
        _Glass.fillAmount = _curentDrinkVolume / _maxDrinkVolume;
    }
    public void CheckIngridients()
    {
        for (int i = 0; i < ingrideentsID.Count; i++) 
        {

            for (int j = 0; j < _firstOrderSO._Ids.Count; j++)
            {
               
                if (ingrideentsID[i] == _firstOrderSO._Ids[j])
                {
                    
                    _counter++;

                }
            }
        }
        Debug.Log(_counter);
        if(_counter == 4)
        {

            _isRecepyGood = true;
        } else
        {
            _isRecepyGood = false;
        }
    }
    public void AddInDrink(int _id)
    {
        ingrideentsID.Add(_id);
        
        _curentDrinkVolume += 19;

    }
    public void Serve()
    {
        CheckIngridients();
        if(_isRecepyGood)
        {
            Win();
        } else
        {
            Loose();
        }
    }
    public void Loose()
    {
        _looseScreen.SetActive(true);
    }
    public void Win()
    {
        _winScreen.SetActive(true);
    }
    public void Restart()
    {
       SceneLoader.LoadcScene();
    }
}
