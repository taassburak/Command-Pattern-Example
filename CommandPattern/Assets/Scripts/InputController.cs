using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

enum MyKeyCode
{
    A = 97,
    B = 98,
    C = 99,
    D = 100,
    E = 101,
    F = 102,
    G = 103,
    H = 104,
    I = 105,
    J = 106,
    K = 107,
    L = 108,
    M = 109,
    N = 110,
    O = 111,
    P = 112,
    Q = 113,
    R = 114,
    S = 115,
    T = 116,
    U = 117,
    V = 118,
    W = 119,
    X = 120,
    Y = 121,
    Z = 122,    
}

public class InputController : MonoBehaviour
{
    public ComboApp ComboApp => _comboApp;

    [SerializeField] private ComboChecker _comboChecker;
    
    private ComboApp _comboApp;

    private void Start()
    {
        _comboApp = new ComboApp();
        _comboChecker.Initialize(this);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            string currentKeyString = Input.inputString;

            var uppercaseLettre = currentKeyString.ToUpper();
            
            Debug.Log("Current Key String " + uppercaseLettre);

            KeyCode currentKeyCode = (KeyCode)Enum.Parse(typeof(KeyCode), uppercaseLettre);

            Debug.Log(currentKeyCode);

            StoreCommand(currentKeyCode);

        }
    }

    public void StoreCommand(KeyCode keyCode)
    {
        ICommand storedCommand = new InputCommand(_comboChecker);
        //storedCommand.Execute(keyCode);
        Debug.Log(keyCode);
        _comboApp.AddCommand(storedCommand, keyCode);

    }

}
