using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Service;
using UnityEngine.InputSystem;
using UnityEditor.PackageManager;

public class InputListener : MonoBehaviour
{
    [SerializeField] private IngridientPicker _ingridientPicker;
    [SerializeField] private LayerMask _ingridient;
    [SerializeField] private Camera _camera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider)
            {
                
                if (LayerChecker.CheckLayersEquality(hit.collider.gameObject.layer, _ingridient))
                {
                    _ingridientPicker.DefineWhatPicked(hit.collider.gameObject);
                }
            }
        }   
    }
    
}
