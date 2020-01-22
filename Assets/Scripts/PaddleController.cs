using UnityEngine;
public class PaddleController : MonoBehaviour
{
    public float batasAtas;
    public float batasBawah;
    public float batasKanan;
    public float batasKiri;
    public float kecepatan;
    public string axisY;
    public string axisX;
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {
        float gerakY = Input.GetAxis (axisY) * kecepatan * Time.deltaTime;
        float gerakX = Input.GetAxis (axisX) * kecepatan * Time.deltaTime;

        float nextPosY = transform.position.y + gerakY;
        float nextPosX = transform.position.x + gerakX;

        if (nextPosY > batasAtas)
        {
            gerakY = 0;
        }
        if (nextPosY < batasBawah)
        {
            gerakY = 0;
        }
        if (nextPosX > batasKanan)
        {
            gerakX = 0;
        }
        if (nextPosX < batasKiri)
        {
            gerakX = 0;
        }

        transform.Translate(gerakX, gerakY,0);

        
    }
}
