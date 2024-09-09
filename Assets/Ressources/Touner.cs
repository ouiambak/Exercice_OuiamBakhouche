using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touner : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          PlanetRotate();
    }
    private void PlanetRotate() { 
        Vector3 _direction = Vector3.zero;
        transform.eulerAngles += new Vector3(0, _rotationSpeed,0)*Time.deltaTime;
    }
}
