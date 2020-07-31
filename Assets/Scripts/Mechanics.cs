using UnityEngine;
using UnityEngine.UI;

public class Mechanics : MonoBehaviour
{
    public Text debugText;
    public GameObject goBall;
    Vector3 vBallCoords, vMouseCoords, vTouchCoords;
    public Vector2 vCurrentRoll;
    Touch touch;
    void Rotate()
    {
        this.vBallCoords = this.goBall.transform.position;
        if (Input.GetMouseButtonDown(0))
            this.vMouseCoords = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            if (((vCurrentRoll.x + ((Input.mousePosition.y - this.vMouseCoords.y) * Time.deltaTime)) >= -14f) && ((vCurrentRoll.x + ((Input.mousePosition.y - this.vMouseCoords.y) * Time.deltaTime)) < 14f))
            {
                this.transform.RotateAround(this.vBallCoords, Vector3.right, (Input.mousePosition.y - this.vMouseCoords.y) * Time.deltaTime);
                vCurrentRoll.x += (Input.mousePosition.y - this.vMouseCoords.y) * Time.deltaTime;
            }
            if (((vCurrentRoll.y + ((Input.mousePosition.x - this.vMouseCoords.x) * Time.deltaTime)) >= -20f) && ((vCurrentRoll.y + ((Input.mousePosition.x - this.vMouseCoords.x) * Time.deltaTime)) < 20f))
            {
                this.transform.RotateAround(this.vBallCoords, Vector3.back, (Input.mousePosition.x - this.vMouseCoords.x) * Time.deltaTime);
                vCurrentRoll.y += (Input.mousePosition.x - this.vMouseCoords.x) * Time.deltaTime;
            }
                if (this.transform.rotation.y != 0f)
                this.transform.rotation = new Quaternion(this.transform.rotation.x, 0, this.transform.rotation.z, this.transform.rotation.w);
            this.vMouseCoords = Input.mousePosition;
        }
        if (Input.touchCount > 0)
        {
            this.touch = Input.GetTouch(0);
            switch (this.touch.phase)
            {
                case TouchPhase.Began:
                    this.vTouchCoords = touch.position;
                    break;
                case TouchPhase.Stationary:
                case TouchPhase.Moved:
                    if (((vCurrentRoll.x + ((touch.position.y - this.vTouchCoords.y) * Time.deltaTime)) >= -14f) && ((vCurrentRoll.x + ((touch.position.y - this.vTouchCoords.y) * Time.deltaTime)) < 14f))
                    {
                        this.transform.RotateAround(this.vBallCoords, Vector3.right, (touch.position.y - this.vTouchCoords.y) * Time.deltaTime * 0.2f);
                        vCurrentRoll.x += (touch.position.y - this.vTouchCoords.y) * Time.deltaTime;
                    }
                    if (((vCurrentRoll.y + ((touch.position.x - this.vTouchCoords.x) * Time.deltaTime)) >= -14f) && ((vCurrentRoll.y + ((touch.position.x - this.vTouchCoords.x) * Time.deltaTime)) < 14f))
                    {
                        this.transform.RotateAround(this.vBallCoords, Vector3.back, (touch.position.x - this.vTouchCoords.x) * Time.deltaTime * 0.2f);
                        vCurrentRoll.y += (touch.position.x - this.vTouchCoords.x) * Time.deltaTime;
                    }
                    if (this.transform.rotation.y != 0)
                        this.transform.rotation = new Quaternion(this.transform.rotation.x, 0, this.transform.rotation.z, this.transform.rotation.w);
                    this.vTouchCoords = touch.position;
                    break;
                default: break;
            }
        }
    }
    public void Reset()
    {
        this.transform.SetPositionAndRotation(Vector3.zero, new Quaternion(0, 0, 0, 1));
        this.vCurrentRoll = Vector2.zero;
    }

    void Start() => Reset();
    void Update() => Rotate();
}
