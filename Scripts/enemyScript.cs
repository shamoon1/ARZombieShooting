using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyScript : MonoBehaviour
{
    public Image power;
    int DestroyThis;
    public Animation anim;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        anim = this.gameObject.GetComponent<Animation>();
        DestroyThis = 0;
        power.fillAmount = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, player.position) < 2f)
        {
            anim.CrossFade("attack");
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.position, 1f*Time.deltaTime);
            anim.CrossFade("walk");
        }



        if (DestroyThis == 0)
        {
            print("notDestroyed");
            if (power.fillAmount <= 0)
            {
                print("Destroyed");
                Destroy(this.gameObject);
                DestroyThis = 1;
            }

           
        }
        
    }
}
