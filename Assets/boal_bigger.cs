using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boal_bigger : MonoBehaviour
{
    public Vector3 rotateChange;  
    public Vector3 positionChange;  
    public Vector3 sayi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (rotateChange);
        transform.position += positionChange;
        transform.localScale += sayi;
    }
}
