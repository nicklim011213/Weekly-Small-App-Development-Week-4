using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public int clones = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubtractClones(int amount)
    {
        clones = Mathf.Max(clones - amount, 1);
    }

    public void DivideClones(int amount)
    {
        clones = Mathf.RoundToInt(clones / amount);
    }

    public void MultiplyClones(int amount)
    {
        clones = clones * amount;
    }

    public void AddClones(int amount)
    {
        clones = clones + amount;
    }
}
