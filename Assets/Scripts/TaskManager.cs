using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public Task taskPrefab;
	public List<Task> taskList;
	
	void Start(){
		taskList = new List<Task>();
	}
	public void NewTask(string desc){
		Task newtask = (Task)Instantiate(taskPrefab);
		newtask.transform.SetParent (this.transform, false);
		newtask.SetDesc(desc);
		taskList.Add(newtask);
	}
	
	
}
