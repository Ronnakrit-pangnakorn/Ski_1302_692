using UnityEngine;

public class Trees : MonoBehaviour
{

    private MeshRenderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
            return;
        player.Hp -= 15;
        UIManger.instance.ShowNotiText($"Hurt -15 \nHP: {player.Hp}");

        if (player.Hp <= 0)
        {
            player.Hp = 0;
            UIManger.instance.ShowNotiText($"You are dead!\nPoints: {player.Point}");
            Time.timeScale = 0f;
            UIManger.instance.ShowHideRestartButton(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(94, 69, 46, 255);
    }
}