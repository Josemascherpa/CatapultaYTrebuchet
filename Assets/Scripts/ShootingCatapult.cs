using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ShootingCatapult : MonoBehaviour
{
    [SerializeField]private GameObject baseCatapult;
    [SerializeField]private GameObject targetShot;
    [SerializeField]private GameObject position;
    private Rigidbody rbBase;
    private void Start() {
        rbBase=baseCatapult.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //rbBase.AddTorque(new Vector3(0,0,3000000),ForceMode.Impulse);
            baseCatapult.transform.GetChild(0).GetComponent<Rigidbody>().AddTorque(new Vector3(0,0,500));

            // Sequence mySequence = DOTween.Sequence();
            // mySequence.Append(baseCatapult.transform.DOLocalRotate(new Vector3(0,0,120),0.3f));            
            // // targetShot.transform.DOLocalMove(new Vector3())
            // mySequence.Append(baseCatapult.transform.DOLocalRotate(new Vector3(0,0,110),0.2f));
            // mySequence.Append(baseCatapult.transform.DOLocalRotate(new Vector3(0,0,120),0.5f));
        }
    }
}
