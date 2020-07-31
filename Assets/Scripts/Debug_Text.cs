using UnityEngine;
using UnityEngine.UI;

public class Debug_Text : MonoBehaviour
{
    public GameObject goBall, goLevel, goCamera;
    void Start(){}
    void Update() => this.gameObject.GetComponent<Text>().text = string.Format("DEBUG Info:\n\nLevel transform:\nPosition:\tx: {0},\ty: {1},\tz: {2}\nRotation:\tx: {3},\ty: {4},\tz: {5}\n\nBall transform:\nPosition:\tx: {6},\ty: {7},\tz: {8}\nCamera transform:\nRotation:\tx: {9}\ty: {10}\tz: {11}\nCurrent Roll:\tx: {12}\ty: {13}",
            this.goLevel.transform.position.x, this.goLevel.transform.position.y, this.goLevel.transform.position.z,
            this.goLevel.transform.rotation.x, this.goLevel.transform.rotation.y, this.goLevel.transform.rotation.z,
            this.goBall.transform.position.x, this.goBall.transform.position.y, this.goBall.transform.position.z,
            this.goCamera.transform.rotation.x, this.goCamera.transform.rotation.y, this.goCamera.transform.rotation.z,
            this.goLevel.GetComponent<Mechanics>().vCurrentRoll.x, this.goLevel.GetComponent<Mechanics>().vCurrentRoll.y);
    
}
