using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyscrip : MonoBehaviour
{
    public Animator _anim;
    private AudioSource _au;
    // Start is called before the first frame update
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _au = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            _au.Play();
            _anim.SetBool ("muerte",false);
        }
    }
    public void fin()
    {
        Destroy(this.gameObject);
    }
}
