using UnityEngine;

public class Ball : MonoBehaviour
{
    public void Reset()
    {
        this.transform.SetPositionAndRotation(new Vector3(-25,37,0), new Quaternion(0, 0, 0, 1));
        this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    void Start() => Reset();
    void Update(){}
}
