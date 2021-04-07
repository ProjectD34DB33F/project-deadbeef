using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : CharacterStats
{
    [SerializeField] Text textHP;
    [SerializeField] Text textRe;


    // Start is called before the first frame update
    void Start()
    {
        textHP.text = currentHp + " / " + maxHp.GetValue();
        textRe.text = currentRe + " / " + maxRe.GetValue();
    }

    // Update is called once per frame
    void Update()
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
}