using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dead : MonoBehaviour
{
    //deleted methods start & update bcus we dont want it once nor per frame
    public ParticleSystem collisionParticleSystem;
    public bool once = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bomb_enemy"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("power_up"))
        {
            var em = collisionParticleSystem.emission; //we toggled off emision since we dont want the particles appearing at all times
            Destroy(collision.gameObject);
            score_manager.instance.addPoints();
            if (once) {
                em.enabled = true;
                collisionParticleSystem.Play();
                once = false;
            }
        }

    }
}


