using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : CharacterStats
{
    private bool CanTakeDamage = true;

    [SerializeField] Text textHP;
    [SerializeField] Text textRe;

    // Start is called before the first frame update
    private void Start()
    {
        textHP.text = currentHp + " / " + maxHp.GetValue();
        textRe.text = currentRe + " / " + maxRe.GetValue();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
            textHP.text = currentHp + " / " + maxHp.GetValue();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            UseAbility(10);
            textRe.text = currentRe + " / " + maxRe.GetValue();
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