using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
        public float speedRotate = 0.75f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 1, 0) * speedRotate); 
    }
}
