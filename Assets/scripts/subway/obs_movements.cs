using UnityEngine;

public class obs_movements : MonoBehaviour {
    public Vector3 direction;
    public float speed;

    void Update () {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
