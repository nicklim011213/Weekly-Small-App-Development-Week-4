using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGateEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int _ = Random.Range(0, 2);
        {
            switch (_)
            {
                case 0:
                    {
                        this.gameObject.AddComponent<RandomNegativeGateEffect>();
                        break;
                    }
                case 1:
                    {
                        this.gameObject.AddComponent<RandomPositiveGateEffect>();
                        break;
                    }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
