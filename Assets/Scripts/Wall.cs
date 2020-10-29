using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IWall
{
    float Score { get; }
}

public class Wall : MonoBehaviour, IWall
{
    Rigidbody2D rb;
    [SerializeField] bool isMoved;
    public FloatReference scores;
    public GameObject FireWorks;
    public GameObject floatingPoints;
    [SerializeField] float _score;
    public float Score { get => _score;}

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!isMoved)
            if (rb.velocity.sqrMagnitude > 2.5f || rb.angularVelocity > 40.9f)
            {
                //print(rb.angularVelocity);
                isMoved = true;
                scores.Variable.Value += Score;
                GameObject points = Instantiate(floatingPoints, transform.position,Quaternion.identity);
                points.transform.GetChild(0).GetComponent<TextMesh>().text = Score.ToString();
                Explode();
            }
    }

    void Explode()
    {
        GameObject firework = Instantiate(FireWorks, transform.position, Quaternion.identity);
        firework.transform.parent = transform;
        firework.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        firework.GetComponent<ParticleSystem>().gravityModifier = -0.06f;
        firework.GetComponent<ParticleSystem>().emissionRate = Random.RandomRange(10, 200);
        firework.GetComponent<ParticleSystem>().Play();
        SoundMenager.PlayWoodBrake();
        SoundMenager.PlayFire();
    }

}
