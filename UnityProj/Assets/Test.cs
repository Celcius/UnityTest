using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test<T> : MonoBehaviour where T : IEnumerable {

	public int Health { get; set;}

	T test;

	// Use this for initialization
	void Start () {
		Health = 1;	
		instanciateOBJ<Test> (this);
	}
	
	// Update is called once per frame
	void Update () {
	 	
	}


	public T instanciateOBJ<T>(T param) 
	{
		test = param;
	}
}
