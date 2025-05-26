using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Class : MonoBehaviour
{
    class Car
    {
        int carNumber;
        int inTime;
        int outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now.Hour;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now.Hour;
        }

    }
    class Product
    {
        public string name;
        public int price;

    }

    class MyMath
    {
        public static double PI = 3.141592;

    }

    class Student
    {
        public string name;
        public int grade;
    }


    private void Start()
    {
        Car car = new Car();
        car.SetInTime();
        car.SetOutTime();

        System.Random random = new System.Random();

        Debug.Log(random.Next(10, 100));
        Debug.Log(random.Next(10, 100));
        Debug.Log(random.Next(10, 100));
        Debug.Log(random.Next(10, 100));
        Debug.Log(random.Next(10, 100));

        Debug.Log(random.NextDouble());
        Debug.Log(random.NextDouble());
        Debug.Log(random.NextDouble());
        Debug.Log(random.NextDouble());
        Debug.Log(random.NextDouble());

        Debug.Log("변형예제" + random.NextDouble() * 10);            //8-1 예제
        Debug.Log("변형예제" + random.NextDouble() * 10);
        Debug.Log("변형예제" + random.NextDouble() * 10);
        Debug.Log("변형예제" + random.NextDouble() * 10);
        Debug.Log("변형예제" + random.NextDouble() * 10);

        List<int> list = new List<int>();
        int[] intArray = new int[10];

        List<int> list2 = new List<int>() { 52, 273, 32, 64 };
        int[] intArray2 = { 52, 273, 32, 65 };

        List<int> list3 = new List<int>();

        list3.Add(52);
        list3.Add(273);
        list3.Add(32);
        list3.Add(64);

        foreach (var item in list3)
        {
            Debug.Log("Count: " + list3.Count + "\tintem : " +item);
        }

        list.Remove(52);

        foreach (var item in list3)
        {
            Debug.Log("Count : " + list3.Count + "\titem : " + item);
        }

        Debug.Log(Mathf.Abs(-52273));
        Debug.Log(Mathf.Ceil(52.273f));
        Debug.Log(Mathf.Floor(52.273f));
        Debug.Log(Mathf.Max(52, 273));
        Debug.Log(Mathf.Min(52, 273));
        Debug.Log(Mathf.Round(52.273f));


        Product product = new Product();

        product.name = "감자";
        product.price = 2000;

        Debug.Log(product.name + " : " + product.price + "원");



        Debug.Log(MyMath.PI);



        List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { name = "홍인록", grade = 1 });
        studentList.Add(new Student() { name = "황이우회", grade = 2 });
        studentList.Add(new Student() { name = "형창용", grade = 3 });
        studentList.Add(new Student() { name = "박서영", grade = 4 });
        studentList.Add(new Student() { name = "김지원", grade = 1 });
        studentList.Add(new Student() { name = "차정하", grade = 2 });

        for (int i = 0; i < studentList.Count; ++i)
        {
            if (studentList[i].name == "김지원")
            {
                studentList.RemoveAt(i);
            }
        }

        foreach (Student item in studentList)
        {
            Debug.Log(item.name + " : " + item.grade);
        }


        //foreach 반복문
        List<Student> studentList2 = new List<Student>();
        studentList2.Add(new Student() { name = "홍인록", grade = 1 });
        studentList2.Add(new Student() { name = "황이우회", grade = 2 });
        studentList2.Add(new Student() { name = "형창용", grade = 3 });
        studentList2.Add(new Student() { name = "박서영", grade = 4 });
        studentList2.Add(new Student() { name = "김지원", grade = 1 });
        studentList2.Add(new Student() { name = "차정하", grade = 2 });

        foreach(Student item in studentList2)
        {
            if(item.grade > 2)
            {
                studentList2.Remove(item);
            }

            Debug.Log(item.name + " : " + item.grade);
        }


        //for 반복문
        List<Student> studentList3 = new List<Student>();
        studentList3.Add(new Student() { name = "홍인록", grade = 1 });
        studentList3.Add(new Student() { name = "황이우회", grade = 2 });
        studentList3.Add(new Student() { name = "형창용", grade = 3 });
        studentList3.Add(new Student() { name = "박서영", grade = 4 });
        studentList3.Add(new Student() { name = "김지원", grade = 1 });
        studentList3.Add(new Student() { name = "차정하", grade = 2 });

        for (int i = studentList3.Count -1; i >= 0; --i)
        {
            if (studentList3[i].grade >= 3)
            {
                studentList3.Remove(studentList3[i]);
            }
        }
    }
}
