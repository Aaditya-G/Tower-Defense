using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   private Transform target;

   PlayerStats playerStats;


   public float speed = 70f;
   public GameObject impactEffect;

   public float explosionRadius = 0f;

   public void Seek(Transform _target){
    target = _target;
   }

   void Start () {
    playerStats =  PlayerStats.instance;
   }

    // Update is called once per frame
    void Update()
    {
        if(target == null){
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame) {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame , Space.World);
        transform.LookAt(target);
    }

    void HitTarget() {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns,2f);
        
        if(explosionRadius >0f){
            Explode();
        }else{
            Damage(target);
        }
        Destroy(gameObject);
    }

    void Damage (Transform enemy) {
        Destroy (enemy.gameObject);
        PlayerStats.Money += 10;
        PlayerStats.Xp += 20;
        Debug.Log(PlayerStats.Money);
        Debug.Log(PlayerStats.Xp);
        playerStats.SaveMoney();
        playerStats.SaveXp();
    }

    void Explode(){
        Collider[] colliders = Physics.OverlapSphere(transform.position , explosionRadius);
        foreach(Collider collider in colliders){
            if(collider.tag == "Enemy"){
                Damage(collider.transform);
            }
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
