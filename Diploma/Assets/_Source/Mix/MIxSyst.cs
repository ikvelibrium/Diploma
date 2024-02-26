using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MIxSyst : MonoBehaviour
{
    [SerializeField] private Image _Glass;

    [SerializeField] private MojitoSO _firstOrderSO;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _looseScreen;
    [SerializeField] private TMP_Text text;
    [SerializeField] private TimerScript _timerScript;
    [SerializeField] private List<MojitoSO> _orders = new List<MojitoSO>();
    public  List<int> ingrideentsID = new List<int>();

    
    private int _counterTillWin = 0;
    private float _maxDrinkVolume = 100;
    private float _curentDrinkVolume = 0;

    private bool _isRecepyGood;
    private int _counter = 0;
    private int _idSum = 0;
    private int _ingridientsFromSOSum = 0;
    private void Update()
    {
        _Glass.fillAmount = _curentDrinkVolume / _maxDrinkVolume;
    }
    public void CheckIngridients()
    {
        for (int i = 0; i < ingrideentsID.Count; i++) 
        {
            _idSum += ingrideentsID[i];

            for (int j = 0; j < _orders[_counterTillWin]._Ids.Count; j++)
            {
               
                if (ingrideentsID[i] == _orders[_counterTillWin]._Ids[j])
                {
                    
                    _counter++;

                }
            }
        }
        for (int i = 0; i < _orders[_counterTillWin]._Ids.Count; i++)
        {
            _ingridientsFromSOSum += _orders[_counterTillWin]._Ids[i];
        }
        
        if (_counter == _orders[_counterTillWin]._Ids.Count && _idSum == _ingridientsFromSOSum)
        {
            
            _isRecepyGood = true;
        } else
        {
            _isRecepyGood = false;
        }
        _counter = 0;
        _ingridientsFromSOSum = 0;
        _idSum = 0;
        ingrideentsID.Clear();
    }
    public void AddInDrink(int _id)
    {
        ingrideentsID.Add(_id);
        
        _curentDrinkVolume += 19;

    }
    public void Serve()
    {
        CheckIngridients();
        _curentDrinkVolume = 0;
        if(_isRecepyGood )
        {
            _counterTillWin++;
            if (_counterTillWin >= 3)
            {
                Win();
            } else
            {
                text.text = "Order: " + _orders[_counterTillWin].OrderName;
                _timerScript.ResetTime();

            }



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
