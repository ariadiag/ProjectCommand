using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public Task taskPrefab;
	private List<Task> taskList;
	
	void Start(){
		taskList = new List<Task>();
	}
	public Task NewTask(string desc){
		Task newtask = (Task)Instantiate(taskPrefab);
		newtask.transform.SetParent (this.transform, false);
		newtask.SetDesc(desc);
		taskList.Add(newtask);
		return newtask;
	}
	public bool RemoveTask(string desc){
		Task temp = taskList.Find( x => x.ReadDesc()==desc);
		temp.EndTask();
		return taskList.Remove(temp);
	}
	public bool RemoveTask(Task t){
		t.EndTask();
		return taskList.Remove(t);
	}
	
	public void AddArrow(Vector3 pos){
		
	}
	
	
}
