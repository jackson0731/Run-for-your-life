using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public float range = 500f;
    public bool isplayerin = false;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
            Vector3 dir = player.transform.position - transform.position;
            float angle = Vector3.Angle(dir, transform.forward);
            if (angle < range * 0.5)
            {
                RaycastHit hit;
                LayerMask mask = 1 << LayerMask.NameToLayer("player");
                if (Physics.Raycast(transform.position + transform.up, dir.normalized, out hit, mask))
                {
                    if (hit.collider.gameObject == player)
                    {
                        isplayerin = true;
                    }
                    else
                    {
                        isplayerin = false;
                    }
                }
            }
    }
}
