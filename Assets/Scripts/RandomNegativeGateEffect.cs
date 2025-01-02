using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNegativeGateEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public char ModiferEffect;
    public int ModiferStrength;
    public TextMeshPro textbox;
    public char symbol = 'E';
    bool Activated = false;
    void Start()
    {
        textbox = GetComponentInChildren<TextMeshPro>();
        int _ = Random.Range(0, 2);
        switch (_)
        {
            case 0:
                {
                    // Divide
                    ModiferEffect = 'd';
                    _ = Random.Range(2, 5);
                    ModiferStrength = _;
                    symbol = '÷';
                    break;
                }
            case 1:
                {
                    // Subtract
                    ModiferEffect = 's';
                    _ = Random.Range(5, 20);
                    ModiferStrength = _;
                    symbol = '-';
                    break;
                }
        }

        textbox.text = symbol.ToString() + ModiferStrength.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !Activated)
        {
            if (ModiferEffect == 'd')
            {
                other.gameObject.GetComponent<CloneHandler>().DivideClones(ModiferStrength);
            }
            else
            {
                other.gameObject.GetComponent<CloneHandler>().SubtractClones(ModiferStrength);
            }
            Activated = true;
        }
    }
}
