using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyV3 : MonoBehaviour
{
    public int life;
    public float delay;
    public SpriteRenderer sprtRen;
    bool isDead;
    void Start()
    {
       sprtRen = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      if(!isDead)
        {
            if(life <= 0) 
            {
                isDead = true;
                StartCoroutine(MuerteAnim(1));
            }
        }
    }

    IEnumerator MuerteAnim(float seconds)
    {
        yield return new WaitForSeconds(delay);

        for(float timer = 0; timer < seconds; timer += Time.deltaTime)
        {
            sprtRen.color = new Color(1,1,1,Mathf.Lerp(1,0, timer / seconds));
            yield return null;
        }
        

    }
}
