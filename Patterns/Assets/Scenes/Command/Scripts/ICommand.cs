using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//L'interface de commande qui possède les méthodes Execute() et Undo()
//Sur l'UML du Command pattern, il s'agit du CommandBase
public interface ICommand
{
    void Execute();
    void Undo();
}
