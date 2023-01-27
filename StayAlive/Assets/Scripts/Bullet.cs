using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Score = Assets.Scripts.Score;

public class Bullet : MonoBehaviour
{
    public float Speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 3f);
        Score.ShotsFired++;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.forward * Time.deltaTime * this.Speed;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null)
        {
            if (collision.gameObject.GetComponent<Enemy>() != null)
            {
                // hit head
                if (collision.collider.GetType() == typeof(SphereCollider))
                {
                    collision.gameObject.GetComponent<Enemy>().ApplyDamage(true);
                    Debug.Log("Hit Head");
                    Score.ShotsHited++;
                }
                else if (collision.collider.GetType() == typeof(BoxCollider))
                {
                    collision.gameObject.GetComponent<Enemy>().ApplyDamage(false);
                    Debug.Log("Hit Body");
                    Score.ShotsHited++;
                    Score.Headshots++;
                }
            }
            
        }
    }
}
