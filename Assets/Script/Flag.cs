using UnityEngine;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player p = other.gameObject.GetComponent<Player>();
        if (p == null)
            return;

        p.Point += 10;

        UiManager.Instance.ShowNotiText($"+10 points\nPoints: {p.Point}");
        Destroy(gameObject);
    }
}
            