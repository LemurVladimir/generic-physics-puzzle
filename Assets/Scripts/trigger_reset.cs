using UnityEngine;

public class trigger_reset : MonoBehaviour
{
    public GameObject goBall, goLevel;
    protected void OnTriggerEnter(Collider other) => this.GameReset();
    public void GameReset()
    {
        this.goLevel.GetComponent<Mechanics>().Reset();
        this.goBall.GetComponent<Ball>().Reset();
    }
}
