using UnityEngine;

public class DestroyerOfPoints : MonoBehaviour
{
    [SerializeField] private GameEvent scoreEvent;
    [SerializeField] private GameEvent playerPassEvent;
    [SerializeField] private GameEvent collideWithPlayer;

    private void OnTriggerEnter2D(Collider2D other) {        
        if(other.gameObject.CompareTag("Player")) {       
        collideWithPlayer.Raise(); 
        Destroy(gameObject);
        return;
        }

        if(other.gameObject.CompareTag("Gate")){
            scoreEvent.Raise();
            playerPassEvent.Raise();
            Destroy(gameObject, 2f);
            return;
        }
    }
}
