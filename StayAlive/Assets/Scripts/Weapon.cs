using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Barrel;
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        if (this.Barrel == null || this.Bullet == null) return;

        Debug.Log("Shot");

        Instantiate(this.Bullet, this.Barrel.position, this.Barrel.rotation);


        /*RaycastHit hit;
        Ray ray = new Ray(this.Barrel.position, this.Barrel.forward);

        Debug.DrawLine(this.Barrel.position, this.Barrel.forward, Color.red, 5.0f);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.rigidbody != null)
            {
                var body = hit.rigidbody;

                body.AddForceAtPosition(this.Barrel.forward * 500f, hit.point);
                Debug.Log(body.gameObject.name);

                if (body.GetComponent<Enemy>() != null)
                {
                    var enemy = body.GetComponent<Enemy>();
                    enemy.ApplyDamage();
                }
            }
        }*/
    }
}
