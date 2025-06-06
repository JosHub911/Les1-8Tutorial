using UnityEngine;
using UnityEngine.UIElements;

public class Les2 : MonoBehaviour
{
    [SerializeField]private float speed = 10f;
    private Rigidbody rb;

    private bool isOnFloor = true;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        transform.position = new Vector3(-4.08f, 0.5f, -8.91f);
        transform.rotation = Quaternion.Euler(0f, 45f, 0f);
        transform.localScale = Vector3.one * 2f;    
    }

  
    void Update()
    {
        transform.position = transform.position + Vector3.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");

        transform.Rotate(Vector3.right , 1f + Input.GetAxis("Horizontal"));

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            isOnFloor = false;
        }

     
        
    }
}
