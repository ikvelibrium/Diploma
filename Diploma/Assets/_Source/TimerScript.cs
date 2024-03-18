using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timer;
    [SerializeField] private float _timerMax;
    [SerializeField] private MIxSyst _mixSyst;
    [SerializeField] private List<Sprite> _clientsMood = new List<Sprite>();
    [SerializeField] private Image _customerMood;
    private float _timerActual;

    private void Start()
    {

        _timerActual = _timerMax;

    }
    private void Update()
    {
        _timer.fillAmount = _timerActual / _timerMax;
        _timerActual -= Time.deltaTime;
        
        if (_timerActual > _timerMax / 3 + _timerMax / 3)
        {
            _customerMood.sprite = _clientsMood[0];
        } else if (_timerActual > _timerMax / 3 && _timerActual < _timerMax + _timerMax / 3)
        {
            _customerMood.sprite = _clientsMood[1];
        } else
        {
            _customerMood.sprite = _clientsMood[2];
        }
        if (_timerActual < 0)
        {
            _mixSyst.Loose();
        }
    }

    public void ResetTime()
    {
        _timerActual = _timerMax;
    }
}