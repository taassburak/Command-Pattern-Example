using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ComboApp 
{
	public Stack<ICommand> CommandList => _commandList;
    private Stack<ICommand> _commandList;

	public ComboApp()
	{
		_commandList = new Stack<ICommand>();
	}

	public void AddCommand(ICommand newCommand, KeyCode keycode)
	{
		_commandList.Push(newCommand);
		newCommand.Execute(keycode);
	}

	public void RefreshStack()
	{
		_commandList.Clear();
	}

	public void RefrestStack(int startIndex)
	{
		_commandList.Clear();
	}
}
