using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repositon : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playerPos = GameManager.instance.transform.position;
        Vector3 mypos = transform.position;
        float diffx = Mathf.Abs(playerPos.x - mypos.x);
        float diffy = Mathf.Abs(playerPos.y - mypos.y);

        Vector3 playerDir = GameManager.instance.player.inputVec;
        float dirx = playerDir.x < 0 ? -1 : 1;
        float diry = playerDir.y < 0 ? -1 : 1;

        switch (transform.tag)
        {
            case "Ground" :
                if (diffx > diffy)
                {
                    transform.Translate(Vector3.right * dirx * 40);
                }
                else if (diffx < diffy)
                { 
                    transform.Translate(Vector3.up * diry * 40);
                }
                    break;

            case "Enemy":


                break;
        }
    }
}
