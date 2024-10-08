using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private ArrayList _observers = new ArrayList();

    protected void Attach(Observer obs)
    {
        _observers.Add(obs);
    }
    protected void Dettach(Observer obs)
    {
        _observers.Remove(obs);
    }

    protected void NotifyObservers()
    {
        foreach (Observer observer in _observers)
        {
            observer.Notify(this);
        }
    }
}
