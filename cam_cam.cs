using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_cam : MonoBehaviour
{
    public float moveX = 0f; // Distance à parcourir sur X
    public float moveY = 0f; // Distance à parcourir sur Y
    public float moveZ = 0f; // Distance à parcourir sur Z
    public float speed = 5f; // Vitesse max de déplacement
    public float smoothTime = 0.3f; // Temps d'adoucissement

    private Vector3 velocity = Vector3.zero; // Vitesse actuelle pour SmoothDamp
    private Vector3 targetPosition;
    private Vector3 lastMoveValues; // Stocke les dernières valeurs saisies
    private bool hasStopped = false;
    public Camera cam;

    void Start()
    {

        GetComponent<Camera>().enabled = false;
        GetComponent<Camera>().enabled = true;

        UpdateTargetPosition();
        lastMoveValues = new Vector3(moveX, moveY, moveZ);
    }

    void Update()
    {
        // Détecte un changement de valeurs
        if (lastMoveValues != new Vector3(moveX, moveY, moveZ))
        {
            UpdateTargetPosition();
            hasStopped = false;
            lastMoveValues = new Vector3(moveX, moveY, moveZ);
        }

        if (!hasStopped)
        {
            // Utilisation de SmoothDamp pour un mouvement fluide
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                hasStopped = true;
                moveX = moveY = moveZ = 0f; // Remet les axes à zéro
            }
        }
    }

    void UpdateTargetPosition()
    {
        targetPosition = transform.position + new Vector3(moveX, moveY, moveZ);
        velocity = Vector3.zero; // Réinitialiser la vitesse pour éviter un à-coup
    }
}