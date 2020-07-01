using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class spin : MonoBehaviour
{

   private void Update()
    {
        UnityEngine.Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        UnityEngine.Quaternion rotation = UnityEngine.Quaternion.AngleAxis(angle - 90, UnityEngine.Vector3.forward);
        transform.rotation = rotation;
    }
}
