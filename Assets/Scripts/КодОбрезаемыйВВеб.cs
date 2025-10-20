using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[Preserve]
public class КодОбрезаемыйВВеб 
{
    // Start is called before the first frame update
    [Preserve]
    void Start()
    {
        SceneManager.LoadScene(0);
        System.Convert.ToString(1);
        System.Convert.ToString(1f);
        MeshRenderer meshRenderer = null; 
        meshRenderer.material = null;
        Rigidbody rigidBody = null;
        rigidBody.AddForce(Vector3.forward);
        rigidBody.isKinematic = true;
        
        NavMeshAgent navMeshAgent = null;
        navMeshAgent.ResetPath();
        navMeshAgent.velocity += Vector3.zero;
        navMeshAgent.SetDestination(Vector3.forward);
        CapsuleCollider capsuleCollider = null;
        capsuleCollider.enabled = true;
        SphereCollider sphereCollider = null;
        sphereCollider.isTrigger = true;
        Transform transform = null;
        transform.Rotate(Vector3.up, 1);
        transform.localEulerAngles = Vector3.forward;
        UnityEngine.Time.timeScale = 1.5f;
            
            
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
