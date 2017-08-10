using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class na : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void menu()
	{
		SceneManager.LoadScene ("uno");

	}

	public void camisas()
	{
		SceneManager.LoadScene ("camisas");

	}

	public void entrega()
	{
		SceneManager.LoadScene ("entrega");

	}

	public void salir()
	{
		Application.Quit ();

	}

	public void contacto()
	{
		Application.OpenURL( "tel://7772867988" );
	}
}

