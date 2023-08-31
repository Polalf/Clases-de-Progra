using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlleV2 : MonoBehaviour
{
    bool isMoving; 
    [SerializeField] AnimationCurve curve;
    [SerializeField] float seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destinoPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destinoPos.z = 0;
        
        if(!isMoving)
        {
            if(Input.GetMouseButton(0))
            {
                StartCoroutine(Moviendo(destinoPos));
            }
        }
    }
    IEnumerator Moviendo(Vector3 Destino)
    {
        Vector3 a = transform.position;
        Vector3 b = Destino;

        isMoving = true;
        for (float i = 0; i < seconds; i+= Time.deltaTime)
        {
            float t = curve.Evaluate(i/seconds);
            transform.position = Vector3.LerpUnclamped(a,b,t); //UnClamped Es para que pase de largo
            yield return null;
        }
        isMoving = false;
        
    }
}
