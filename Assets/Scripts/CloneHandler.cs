using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public int clones = 1;
    public int nonclonechildren = 0;
    public GameObject model;
    void Start()
    {
        nonclonechildren = this.gameObject.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if ((clones - 1) != this.transform.childCount - nonclonechildren)
        {
            int childrenneeded = (clones - 1) - (this.transform.childCount - nonclonechildren);
            if (childrenneeded > 0)
            {
                for (int i = childrenneeded; i > 0; --i)
                {
                    var child = GameObject.Instantiate(model);
                    child.transform.SetParent(transform, false);
                    child.transform.position = this.gameObject.transform.position;
                    child.transform.rotation = this.gameObject.transform.rotation;
                    child.transform.localPosition += new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
                }
            }
            else if (childrenneeded < 0)
            {
            
                for (int j = this.transform.childCount; j != (clones - 1) + nonclonechildren; --j)
                {
                    GameObject.Destroy(this.gameObject.transform.GetChild(j - 1).gameObject);
                }
            
            }
        }
    }

    public void SubtractClones(int amount)
    {
        clones = Mathf.Max(clones - amount, 1);
    }

    public void DivideClones(int amount)
    {
        clones = Mathf.Max(Mathf.RoundToInt(clones / amount), 1);
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
