using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamPos : MonoBehaviour
{
    [SerializeField] GameObject Followcam;
    [SerializeField] float campos_x;
    [SerializeField] float campos_y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Followcam.transform.position + new Vector3 (0, campos_x ,campos_y);

        
    }
}
