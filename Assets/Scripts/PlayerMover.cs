using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Vector3 newPosition;
    private Vector3 bounds;
    private float counter = 0;
    private Animator animator;

    [SerializeField] private float waitTime = 1f;
    [SerializeField] private float speed = 5f;

    private void Start() {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        animator = GetComponent<Animator>();
        newPosition = transform.position;
    }
    private void Update() {        
        counter += Time.deltaTime;
       
        if(counter >= waitTime){            
            newPosition = GetRandomPosition();
                    
            counter = 0f;
        }

        transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime* speed);

        animator.SetBool("IsUpDown", false);        
        if(!(Vector2.Distance(transform.position, newPosition) < Time.deltaTime * speed)){
            animator.SetBool("IsUpDown", true);
        }

    }

    private Vector3 GetRandomPosition(){
        var randomPosition = Random.Range(Mathf.RoundToInt(-bounds.y), Mathf.RoundToInt(bounds.y));
        
        return new Vector3(transform.position.x, randomPosition, transform.position.z);
    }
}
