using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject Target;

    public float MovementSpeed = 5f;

    private float currentHealth = 3f;

    public Text HealthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target == null) return;
        this.transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, this.MovementSpeed * Time.deltaTime);
        this.transform.position = new Vector3(this.transform.position.x, 0f, this.transform.position.z);
        this.transform.LookAt(this.Target.transform);

        this.transform.rotation = new Quaternion(0f, this.transform.rotation.y, 0, this.transform.rotation.w);

        if (this.currentHealth <= 0f)
        {
            Score.CurrentKills++;
            Destroy(this.gameObject);
        }
    }

    public void ApplyDamage(bool headShot)
    {
        if(headShot)
            Destroy(this.gameObject);
        else
        {
            this.currentHealth--;
        }

        this.HealthText.text = "HP: " + currentHealth + "/3";
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null)
        {
            Debug.Log(collision.gameObject.name);
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                Debug.Log("HIT PLAYER");
                collision.gameObject.GetComponent<PlayerController>().ApplyDamage();
            }

        }
    }
}
