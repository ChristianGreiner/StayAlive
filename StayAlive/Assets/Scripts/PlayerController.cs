using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Weapon CurrentWeapon;

    private int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.CurrentWeapon != null)
            {
                this.CurrentWeapon.Fire();
            }
        }
    }

    public void ApplyDamage()
    {
        this.health--;
        if (this.health <= 0)
        {
            // dead
            Object.Destroy(this.gameObject);
        }
    }
}
