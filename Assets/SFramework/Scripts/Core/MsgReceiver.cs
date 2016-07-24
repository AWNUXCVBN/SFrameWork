using UnityEngine;
using System.Collections;
using SFramework; 

public class MsgReceiver : MonoBehaviour,IMsgReceiver {

    void Awake()
    {
        this.RegisterGlobalMsg("MsgTest", ReceiverMsg); 
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ReceiverMsg(params object[] paramList)
    {
        foreach (var sth in paramList)
        {
            Debug.LogWarning(sth.ToString());
        }
    }
}
