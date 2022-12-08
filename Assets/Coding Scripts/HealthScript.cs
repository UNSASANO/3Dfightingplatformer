using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public Image HPbar;
    public float max_health = 100f;
    public float cur_health = 0f;


// Start is called before the first frame update
    void Start()
    {
       cur_health = max_health;
       SetHealthBar ();
    }

    public void TakeDamage(float amount)
    {
        cur_health -= amount;
        SetHealthBar ();
    }

    public void SetHealthBar()
    {
        float my_health = cur_health / max_health;
        HPbar.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), HPbar.transform.localScale.z);
          

    }
    
}
