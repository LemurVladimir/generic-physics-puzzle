using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject goBall;
    void Start(){}
    void Update()
    {
        this.transform.SetPositionAndRotation(new Vector3(this.goBall.transform.position.x, this.goBall.transform.position.y + 4f, this.goBall.transform.position.z - 15f), this.goBall.transform.rotation);
        this.transform.LookAt(this.goBall.transform);
    }
}
