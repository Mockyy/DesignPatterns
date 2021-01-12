using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//La commande pour le cube
//Sur l'UML du Command parttern, il s'agit du Receiver
public class Command : ICommand
{
    private GameObject _cube;
    private Color _color;

    private Color previousColor;
    private Color nextColor;

    //constructeur de la commande, on lui passe les éléments que l'on va modifier
    public Command(GameObject cube, Color color)
    {
        _cube = cube;
        _color = color;
    }

    //Execution de la commande, ici on applique une nouvelle couleur à l'objet
    public void Execute()
    {
        previousColor = _cube.GetComponent<MeshRenderer>().material.color;  //On stocke la couleur actuelle afin 
                                                                            //de pouvoir la retrouver lors du Undo()
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    //Reviens à l'état précédent
    public void Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color = previousColor;
    }
}
