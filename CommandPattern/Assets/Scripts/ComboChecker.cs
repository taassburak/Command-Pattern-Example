using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ComboChecker : MonoBehaviour
{
    [SerializeField] private List<KeyCode> _comboKeys; 

    private InputController _inputController;

    internal void Initialize(InputController inputController)
    {
        _inputController = inputController;
    }

    internal void CheckCombo()
    {
        if (_inputController.ComboApp.CommandList.Count < _comboKeys.Count)
        {
            return;
        }
        for (int i = 0; i <= _comboKeys.Count - 1; i++)
        {
            if (_inputController.ComboApp.CommandList.ElementAt(i).GetKeyCode() != _comboKeys[i])
            {
                return;
            }
        }

        Debug.Log("CORRECT COMBO");
        _inputController.ComboApp.RefreshStack();
    }

    

    
}
