
using UnityEngine;

public class playerFollow : MonoBehaviour
{

    public Transform Player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
