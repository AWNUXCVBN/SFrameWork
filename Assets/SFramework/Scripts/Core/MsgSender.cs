using UnityEngine;
using System.Collections;
using SFramework;
public class MsgSender : MonoBehaviour,IMsgSender
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.SendGlobalMsg("MsgTest", "你好", "世界");
    }
}
