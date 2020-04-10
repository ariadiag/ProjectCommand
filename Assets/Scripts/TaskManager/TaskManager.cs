using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public Task taskPrefab;
	public List<Task> taskList;
	
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
		if (taskList.Count!=0){
			Task temp = taskList.Find( t => t.ReadDesc().Equals(desc));
			return RemoveTask(temp);
		} return false;
	}
	public bool RemoveTask(Task t){
		t.EndTask();
		return taskList.Remove(t);
	}
	
	public void AddArrow(Vector3 pos){
		
	}
	
	
}
