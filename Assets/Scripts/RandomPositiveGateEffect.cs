using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomPositiveGateEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public char ModiferEffect;
    public int ModiferStrength;
    public TextMeshPro textbox;
    public char symbol = 'E';
    void Start()
    {
        textbox = GetComponentInChildren<TextMeshPro>();
        int _ = Random.Range(0, 2);
        switch (_)
        {
            case 0:
                {
                    // Divide
                    ModiferEffect = 'a';
                    _ = Random.Range(3, 25);
                    ModiferStrength = _;
                    symbol = '+';
                    break;
                }
            case 1:
                {
                    // Subtract
                    ModiferEffect = 'm';
                    _ = Random.Range(2, 5);
                    ModiferStrength = _;
                    symbol = 'X';
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
        if (other.gameObject.tag == "Player")
        {
            if (ModiferEffect == 'm')
            {
                other.gameObject.GetComponent<CloneHandler>().MultiplyClones(ModiferStrength);
            }
            else
            {
                other.gameObject.GetComponent<CloneHandler>().AddClones(ModiferStrength);
            }
        }
    }
}
