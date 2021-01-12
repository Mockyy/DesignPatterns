using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//L'input manager attaché à l'avatar
//Ici, il est attaché à la caméra et permet de gérer le clic gauche et la touche Z
//Sur l'UML du Command pattern, il s'agit du Client
public class InputManager : MonoBehaviour
{
    private void Update()
    {
        //Quand le joueur click gauche
        if (Input.GetMouseButtonUp(0))
        {
            //On envoie un raycast à la position de la souris
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //Si le raycast touche un objet (ici un cube), on crée une commande avec une couleur random
            if (Physics.Raycast(rayOrigin, out hit))
            {
                if (hit.collider.name == "Cube")
                {
                    Color c = new Color(Random.value, Random.value, Random.value);

                    ICommand click = new Command(hit.collider.gameObject, c);   //Création de la commande

                    CommandManager.Instance.StoreAndExecute(click);     //On stocke la commande dans une liste 
                                                                        //et on execute la méthode associée

                }
            }
        }

        //Si on appuie sur la touche Z
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CommandManager.Instance.DestoreAndUndo();   //On undo la dernière commande effectuée et on la 
                                                        //retire de la liste
        }
    }
}
