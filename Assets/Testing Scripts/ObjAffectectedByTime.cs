using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjAffectectedByTime : MonoBehaviour
{
    private TimeController timeController;
    private float timeDilation = 1f;

    private void Awake()
    {
        timeController = GetComponent<TimeController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        timeController.OnTimeChange += OnTimeChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTimeChange(object sender, TimeController.OnTimeChangeArgs e)
    {
        timeDilation = e.newTimeDilation;
    }
}
