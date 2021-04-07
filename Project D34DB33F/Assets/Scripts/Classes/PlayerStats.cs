using System.Collections;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    private bool CanTakeDamage = true;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            UseAbility(10);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (CanTakeDamage)
            {
                StartCoroutine(ContinuousDamage());
                TakeDamage(10);
                SoundTouched.soundTch.PlayDeathSound();
            }
        }
    }

    private IEnumerator ContinuousDamage()
    {
        CanTakeDamage = false;
        yield return new WaitForSeconds(1);
        CanTakeDamage = true;
    }
}