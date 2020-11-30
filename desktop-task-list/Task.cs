using System;

public class Task
{

	public bool isCompleted
    {
		get { return isCompleted; }
		set { isCompleted = value; }
    }

	public string taskText
	{
		get { return taskText; }   
		set { taskText = value; }  
	}

	public Task()
	{
		isCompleted = false;
		taskText = "";
	}

	public Task(bool completion, string text)
    {
		isCompleted = completion;
		taskText = text;
    }

	public void complete()
    {
		isCompleted = true;
    }

	public void clear()
    {
		isCompleted = false;
		taskText = "";
    }

 
}
