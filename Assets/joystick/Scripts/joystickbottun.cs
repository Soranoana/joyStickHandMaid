using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickbottun : MonoBehaviour {

    public GameObject EffectiveObject;

    /* オブジェクトをタップしたら */
    public void PushDown() {
        //処理
        PushDownEvent();
    }

    /* オブジェクトをタップし終えたら */
    public void PushUp() {
        //処理
        PushUpEvent();
    }

    /* タップ時のイベント一覧 */
    private void PushDownEvent() {
        if (EffectiveObject.name=="Cube") {
            //処理1
            EffectiveObject.transform.GetComponent<MeshRenderer>().enabled=false;
        } else if (EffectiveObject.name=="") {
            //処理2
        } else {
            Debug.LogError("Unknown obejct was tapped.");
        }
    }

    /* タップ終了時のイベント一覧 */
    private void PushUpEvent() {
        if (EffectiveObject.name=="Cube") {
            //処理1
            EffectiveObject.transform.GetComponent<MeshRenderer>().enabled=true;
        } else if (EffectiveObject.name=="") {
            //処理2
        } else {
            Debug.LogError("Unknown obejct was tapEnded.");
        }
    }
}
