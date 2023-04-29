using UnityEngine;
//using TMPro;

public class ObjectDestroyer : MonoBehaviour {
    //public TextMeshProUGUI countText;
    private int count = 0;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            ++count;
            //countText.text = "Count: " + count.ToString();
            Debug.Log("Coins collected: " + count);
        }
    }
}
