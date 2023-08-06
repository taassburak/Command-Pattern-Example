using UnityEngine;

public interface ICommand 
{
    void Execute(KeyCode keyCode);
    KeyCode GetKeyCode();
}
