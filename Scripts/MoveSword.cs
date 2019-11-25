using UnityEngine;
using System.Collections;

public class MoveSword : MonoBehaviour {
    
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            // Overhead
            GetComponent<Animator>().SetTrigger("OverheadSwing");
        }
        else if (Input.GetMouseButtonDown(1)) {
            // Sideswing
            GetComponent<Animator>().SetTrigger("SideSwing");
        }
    }
}
