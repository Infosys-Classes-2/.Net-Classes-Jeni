using System.Collections.Generic;
using Members;
using System;
public class Collection
{
    //all of these are data structures (data structure- way of holding different data types)
    //List
    //Stack
    //Queue
    //Dictionary


    //Example of List
    void TestList()
    {
        List<byte> ageOfStudents =new List<byte>();
        ageOfStudents.Add(20);
        ageOfStudents.Add(33);
        ageOfStudents.Add(22);
        ageOfStudents.Add(44);
        ageOfStudents.Add(55);
        ageOfStudents.Add(66);
        ageOfStudents.Remove(66);

        foreach(var age in ageOfStudents)
        Console.WriteLine(age);

        List<Person> people = new List<Person>();
        people.Add(new Person());
        //or 
        var s = new Person();
        people.Add(s);


        //Stack
        void TestStack()
        {
            //LIFO
            Stack<string> plates = new Stack<string> ();
            //or  Stack<string> plates = new ();
            plates.Push("plate1");
            plates.Push("plate2");
            plates.Push("plate3");
            plates.Push("plate4");
            plates.Pop();  // as it pop out the data serially in LIFO we don't have to give any parameter in pop

        }

        //Queue
        void TestQueue()
        {
            //FIFO
            Queue<string> patientLine = new Queue<string>();
            //or  Queue<string> patientLine = new();
            patientLine.Enqueue("Patient 1");
            patientLine.Enqueue("Patient 2");
            patientLine.Enqueue("Patient 3");
            patientLine.Enqueue("Patient 4");
            patientLine.Dequeue(); //removes the patient 1 as it's queue
        }

        //Dictionary
        void TestDictionary()
        {
            Dictionary<string, long> population =new() ; // example to save population of countries
            population.Add("NEPAL",2664545652);
            population.Add("INDIA",15456555656);
            population.Add("CHINA",5485454578);
            // or
            //["NEPAL"] =2664545652,
            //["INDIA"]=15456555656,
            //["CHINA"]=5485454578

           // population.Add("CHINA",5485454578); //IT SHOWS ERROR AS THE DICTIONARY WON'T GIVE DUPLICATE VALUE
            population.Remove("INDIA");
        }



    

    }
}