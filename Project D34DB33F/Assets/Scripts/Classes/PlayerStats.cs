using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : CharacterStats
{
    bool canTakeDamage = true;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //if (currentHp <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (canTakeDamage)
            {
                StartCoroutine(ContinuousDamage());
                TakeDamage(10);
                SoundTouched.soundTch.PlayDeathSound();
            }
        }
    }

    private IEnumerator ContinuousDamage()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(1);
        canTakeDamage = true;
    }

}