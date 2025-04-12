using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arch_vision : MonoBehaviour
{
    public cam_cam cameraScript; // Référence au script cam_cam

    void Start()
    {
        if (cameraScript == null)
        {

            cameraScript.gameObject.SetActive(false);
            cameraScript.gameObject.SetActive(true);
            Debug.LogError("Référence à cam_cam manquante !");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Exemple : Appuyer sur ESPACE
        {
            MoveCamera(2f, 3f, 5f); // Déplacer la caméra
        }
    }

    // Fonction pour modifier les axes de mouvement
    public void MoveCamera(float x, float y, float z)
    {
        if (cameraScript != null)
        {
            cameraScript.moveX = x;
            cameraScript.moveY = y;
            cameraScript.moveZ = z;
            Debug.Log("Caméra déplacée !");
        }
    }
}