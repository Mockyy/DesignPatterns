using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//L'alarme joue un son lorqu'un ennemi entre en collision avec le joueur
public class Alarm : MonoBehaviour
{
    private void OnEnable()
    {
        Alert.playerSpotted += AlarmStart;
        Alert.playerLost += AlarmStop;
    }

    private void OnDisable()
    {
        Alert.playerSpotted -= AlarmStart;
        Alert.playerLost -= AlarmStop;
    }

    private void AlarmStart()
    {
        GetComponent<AudioSource>().Play();
    }

    private void AlarmStop()
    {
        GetComponent<AudioSource>().Stop();
    }
}
