using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Desafio1 : MonoBehaviour
{
    [SerializeField] Queue<Vector3> positions = new Queue<Vector3>(10);
    bool isMoving;
    [SerializeField] float seconds;
    [SerializeField] AnimationCurve curve;
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if(Input.GetMouseButtonDown(0))
        {
            positions.Enqueue(mousePos);
            if (!isMoving)
            {
                StartCoroutine(Moverse());
            }
        }
    }

    IEnumerator Moverse()
    {
        isMoving = true;
        int x = 0;
        while (x < positions.Count)
        {
            
            Vector3 b = positions.Dequeue();
            for (float i = 0; i < seconds; i += Time.deltaTime)
            {
                transform.DOMove(b, seconds);
                yield return null;
            }

        }
        isMoving = false;
    }
}
