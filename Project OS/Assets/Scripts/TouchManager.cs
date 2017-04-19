using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

    public LayerMask touchInputMask;

    private List<GameObject> touchList = new List<GameObject>();
    private GameObject[] touchesOld;

    public static TouchManager thisManager;

    void Update() {
        
#if UNITY_EDITOR
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0)) {


            print("test");
            Ray ray = transform.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, touchInputMask)) {

                GameObject recipient = hit.transform.gameObject;

                if (Input.GetMouseButtonUp(0)) {
                    print("Harry");
                }
            }
            
        }
#endif
        if (Input.touches.Length > 0) {

            touchesOld = new GameObject[touchList.Count];
            touchList.CopyTo(touchesOld);
            touchList.Clear();

            foreach (Touch touch in Input.touches) {

                Ray ray = transform.GetComponent<Camera>().ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, touchInputMask)) {

                    GameObject recipient = hit.transform.gameObject;
                    touchList.Add(recipient);

                    if (touch.phase == TouchPhase.Ended) {
                        print("Harry2");
                    }
                }
            }
            foreach(GameObject g in touchesOld) {
                if (!touchList.Contains(g)) {

                }
            }
        }
    }
}
