using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoteManager : MonoBehaviour
{
    public List<Note> notes;
    public List<int> activeHoles;
    public Note activeNote;

    public static NoteManager instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
            AddHole(1);

        if (Input.GetKeyDown(KeyCode.E))
            RemoveHole(1);*/
    }

    public void AddHole(int number)
    {
        if(activeHoles == null || !activeHoles.Contains(number))
        {
            activeHoles.Add(number);
            CheckNote();
        }
    }

    public void RemoveHole(int number)
    {
        if(activeHoles != null && activeHoles.Contains(number))
        {
            activeHoles.Remove(number);
            CheckNote();
        }
    }

    void CheckNote()
    {
        if(activeNote != null) activeNote.OnStopPlay();

        foreach(Note note in notes)
        {
            if(note.holes == activeHoles)
            {
                activeNote = note;
                return;
            }
            else
                activeNote = null;
        }
    }

    void PlayNote()
    {
        if(activeNote != null)
        {
            activeNote.OnPlayed();
        }
        else
            SoundManager.instance.PlayBadSound();

    }
}
