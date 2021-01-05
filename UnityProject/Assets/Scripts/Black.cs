using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    [Header("血量")]
    public int hp = 10;
    [Header("血量介面")]
    public GameObject text_hp;
    [Header("音效")]
    public AudioClip clip;



   
    void OnCollisionEnter2D(Collision2D collision)
    {

        hp -= 1;        
        
       if (hp<=0)
       {
            Die();
            Destroy(text_hp);
        }
       
           }
    private void Die() 
    {
        Destroy(this.gameObject);
    }
    private void Update()
    {
        
         
    }
}
   
     #endregion
        
