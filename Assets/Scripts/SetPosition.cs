using UnityEngine;

public class SetPosition : MonoBehaviour
{
    private Vector3 dragOffset;
    private Camera myCam;
    private Vector3 screenBounds;

    [SerializeField] private float speed = 10f;

    private void Awake() {
        myCam = Camera.main;
        screenBounds = myCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, myCam.transform.position.z));
    }

    private void OnMouseDown() {
        dragOffset = transform.position - GetMousePosition();
    }

    private void OnMouseDrag() {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePosition() + dragOffset, speed * Time.deltaTime);

        if(transform.position.y >= screenBounds.y){
            transform.position = new Vector3(transform.position.x, screenBounds.y, transform.position.z);
            return;
        }
        
        if(transform.position.y <= -screenBounds.y){
            transform.position = new Vector3(transform.position.x, -screenBounds.y, transform.position.z);
            return;
        }
    }

    private Vector3 GetMousePosition(){
        var mousePosition = myCam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        mousePosition.x = transform.position.x;
        return mousePosition;
    }
}
