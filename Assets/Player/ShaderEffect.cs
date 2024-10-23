using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderEffect : MonoBehaviour
{
    public Transform player;
    public Material grassMaterial;
    // Update is called once per frame
    void Update()
    {
        grassMaterial.SetVector("_PlayerPosition", new Vector3 (player.position.x,0,player.position.z));
    }
}
