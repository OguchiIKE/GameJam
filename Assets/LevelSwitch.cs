using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour {

    public Transform[] level;
    public Transform level2;

    public Transform[] spawn;
    public Transform player;

    public int currentL = 0;

	// Use this for initialization
	void Start () {
        switcher();
        
    }
	
	// Update is called once per frame
	void Update () {
        
		//when we press "Space" the level switches
        if (Input.GetButtonDown("Jump"))
        {
            currentL += 1;
            switcher();
        }
        

        if(currentL >= 2)
        {
            currentL = 0;
        }
	}

    void switcher()
    {
       // Transform lvl;
        //destroy the last level bring the next if last exists
       // if (lvl != null)
       // {
       //    Destroy(lvl);
       // }

        //GameObject lvl;
       // lvl = Instantiate(level[currentL], transform.position, Quaternion.identity);

    }
}
