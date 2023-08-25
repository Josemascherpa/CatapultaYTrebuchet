using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Catapulta : MonoBehaviour
{
    
    [SerializeField]private Rigidbody weight;
    [SerializeField]private GameObject pumpkin;
    [SerializeField]private GameObject positionCamera;
    private bool lookBall=false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            weight.isKinematic = false;
            lookBall=true;
            Camera.main.transform.DOLocalMove(positionCamera.transform.position,0.8f);
        }
        if(lookBall){
            Camera.main.transform.LookAt(pumpkin.transform);
        } 
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }
    }
}
