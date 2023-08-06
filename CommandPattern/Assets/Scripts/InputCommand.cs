using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCommand : ICommand
{
    private ComboChecker _comboChecker;
    private KeyCode _keyCode;

    public InputCommand(ComboChecker comboChecker)
    {
        _comboChecker = comboChecker;
    }

    public void Execute(KeyCode keyCode)
    {
        _keyCode = keyCode;
        _comboChecker.CheckCombo();
    }

    public KeyCode GetKeyCode()
    {
        return _keyCode;
    }
}
