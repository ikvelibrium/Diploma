using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timer;
    [SerializeField] private float _timerMax;
    [SerializeField] private MIxSyst _mixSyst;
    private float _timerActual;

    private void Start()
    {

        _timerActual = _timerMax;

    }
    private void Update()
    {
        _timer.fillAmount = _timerActual / _timerMax;
        _timerActual -= Time.deltaTime;
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