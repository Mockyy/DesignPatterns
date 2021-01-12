using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Le command manager permet de gérer la liste des commandes et fait le lien entre les inputs et les commandes
//Sur l'UML du Command pattern, il s'agit de l'Invoker
public class CommandManager : MonoBehaviour
{
    //Singleton d'instanciation de l'objet
    private static CommandManager _instance;

    public static CommandManager Instance
    {
        get
        {
            if (!_instance)
                Debug.LogError("Command manager missing");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    //La liste des commandes
    private List<ICommand> _commands = new List<ICommand>();

    //La méthode qui ajoute la commande à la liste et l'execute
    public void StoreAndExecute(ICommand command)
    {
        _commands.Add(command);
        command.Execute();
    }

    //La méthode qui Undo la dernière commande et l'enlève de la liste
    public void DestoreAndUndo()
    {
        if (_commands.Count >= 1)
        {
            _commands[_commands.Count - 1].Undo();
            _commands.RemoveAt(_commands.Count - 1);
        }
    }
}
