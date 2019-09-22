using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screen_handler : MonoBehaviour
{
	
    public GameObject screen;
	
	public Text name;
	public Text age;
	
	public Button info;
	public Button info_back;
	public Button trophies;
	public Button trophies_back;
	public Button profile_save;
	public Button profile;
	public Button profile_back;

	Vector3 main_pos;
	
	
	
    void Start()
    {
		
		main_pos = screen.transform.position;
        info.onClick.AddListener(delegate 
		{ info_screen(); });
		info_back.onClick.AddListener(delegate 
		{ main_screen(); });
		trophies.onClick.AddListener(delegate 
		{ awards_screen(); });
		trophies_back.onClick.AddListener(delegate 
		{ main_screen(); });
		profile_save.onClick.AddListener(delegate 
		{ save_profile();});
		profile.onClick.AddListener(delegate 
		{ profile_screen();});
		profile_back.onClick.AddListener(delegate 
		{ main_screen();});
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void info_screen()
	{
		
		screen.transform.position = new Vector3(-70,screen.transform.position.y,screen.transform.position.z);
		Debug.Log("HOLA");	
	}
	
	void main_screen()
	{
		
		screen.transform.position = main_pos;
		
	}
	
	void awards_screen()
	{
		screen.transform.position = new Vector3(80,screen.transform.position.y,screen.transform.position.z);
	}
	
	void save_profile()
	{
		Player_Data p = new Player_Data();
		p.name = name.text;
		p.age = age.text;
		
		string json = JsonUtility.ToJson (p);
		Debug.Log(json);
		PlayerPrefs.SetString ("PlayerProfile",json);
	}
	
	void profile_screen()
	{

	screen.transform.position = new Vector3(145,screen.transform.position.y,screen.transform.position.z);
	

		
	}
	

	
}
