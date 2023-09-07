using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Desafio1 : MonoBehaviour
{
    [SerializeField] Queue<Vector3> positions = new Queue<Vector3>(10);
    bool isMoving;
    [SerializeField] float seconds;
    
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(positions.Count < 10)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            if (Input.GetMouseButtonDown(0))
            {
                positions.Enqueue(mousePos);
                if (!isMoving)
                {
                    StartCoroutine(Moverse());
                }
            }
        }
       
    }

    private float EaseInOutBack(float t)
    {
        float c1 = 1.70158f;
        float c2 = c1 * 1.525f;

        return t < 0.5f ? (Mathf.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) / 2 : (Mathf.Pow(2 * t - 2, 2) * ((c2 + 1) * (t*2 - 2) + c2)+2) / 2;
    }

    IEnumerator Moverse()
    {
        isMoving = true;
        int x = 0;
        while (x < positions.Count)
        {
            Vector3 a = transform.position;
            Vector3 b = positions.Dequeue();
            for (float i = 0; i < seconds; i += Time.deltaTime)
            {
                transform.position = Vector3.LerpUnclamped(a, b, EaseInOutBack(i / seconds));
                //transform.position = Vector3.Lerp(a, b, EaseInOutBack(i / seconds));
                //transform.position = Vector3.Lerp(a, b,(i / seconds));
                yield return null;
            }

        }
        isMoving = false;
    }
}
