using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    AudioSource audio;
    public AudioClip hitSound;

    public int force;
    Rigidbody2D rigid;
    Text scoreUIP1;
    Text scoreUIP2;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        Data.scoreP1 = 0;
        Data.scoreP2 = 0;
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(2,0).normalized;
        rigid.AddForce(arah * force);

        scoreUIP1 = GameObject.Find ("Score1").GetComponent<Text> ();
        scoreUIP2 = GameObject.Find ("Score2").GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResetBall () {
        transform.localPosition = new Vector2(0,0);
        rigid.velocity = new Vector2(0,0);
    }

    private void OnCollisionEnter2D (Collision2D coll) {
        audio.PlayOneShot(hitSound);
        if (coll.gameObject.name == "GawangKanan")
        {

            Data.scoreP1 +=1 ;
            TampilkanScore();
            if (Data.scoreP1 == 5)
            {
                Data.pemenang = "PLAYER BIRU PEMENANG!";
                SceneManager.LoadScene("GameOver");
            }
            ResetBall();
            Vector2 arah = new Vector2(2,0).normalized;
            rigid.AddForce(arah * force);
            
        }

        if (coll.gameObject.name == "GawangKiri")
        {
            Data.scoreP2 +=1 ;
            TampilkanScore();
            if (Data.scoreP2 == 5)
            {
                Data.pemenang = "PLAYER KUNING PEMENANG!";
                SceneManager.LoadScene("GameOver");
            }
            ResetBall();
            Vector2 arah = new Vector2 (-2,0).normalized;
            rigid.AddForce(arah * force);
            
        }

        if (coll.gameObject.name == "Pemukul1" || coll.gameObject.name == "Pemukul2")
        {
            float sudut = (transform.position.y - coll.transform.position.y)*5f;
            Vector2 arah = new Vector2 (rigid.velocity.x, sudut).normalized;
            rigid.velocity = new Vector2(0,0);
            rigid.AddForce(arah * force * 2);
        }

        void TampilkanScore() {
            
            scoreUIP1.text = Data.scoreP1 +"";
            scoreUIP2.text = Data.scoreP2 +"";
        }
    }
}
