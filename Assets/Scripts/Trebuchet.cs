using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Trebuchet : MonoBehaviour
{
    [SerializeField]private GameObject pumpkin;
    [SerializeField]private Rigidbody weight;
    [SerializeField]private GameObject positionCamera;
    private bool lookBall=false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            weight.isKinematic=false;
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            Destroy(pumpkin.GetComponent<HingeJoint>());
            lookBall=true;
            Camera.main.transform.DOLocalMove(positionCamera.transform.position,0.3f);
        }
        if(lookBall){
            Camera.main.transform.LookAt(pumpkin.transform);
        } 
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }
    }
}
