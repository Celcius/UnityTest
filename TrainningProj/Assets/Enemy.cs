using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] float health = 1.0f;
    SpriteRenderer spriteRenderer;
    Rigidbody2D _rigidbody;
    CircleCollider2D circleCollider;

    [SerializeField] Enemy _prefab;

    public static Enemy createInstance(Vector3 position, Enemy prefab) {
        Enemy enemy = GameObject.Instantiate<Enemy>(prefab) as Enemy;
        enemy.transform.position = position;
        return enemy;
        
    }

	private void Awake()
	{
        spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float damage) {
        if (health <= 0)
            return;
        
        health -= damage;
        if(health < 0) {
            health = 0.0f;
            PlayDeath();
        }
    }

    void PlayDeath() {
        Destroy(gameObject);
    }
}
