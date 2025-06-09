using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 2025137023_JHR : MonoBehaviour
{

    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
    }

    class TestA
    {
        public int Multi(int x, int y)
        {
            return x * y;
        }
    }

    class TestB
    {
        public void Print()
        {
            Debug.Log("Debug.Log() �޼��尡 ȣ��Ǿ����ϴ�.");
        }
    }

    class TestC
    {
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i<= max; i++)
            {
                output += i;
            }
            return output;
        }
    }

    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
        public static double Abs(double input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        public static long Abs(long input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }

    class Product2
    {
        public string name;
        public int price;

        public Product2(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        ~Product2()
        {
            Debug.Log(this.name + "�� �Ҹ��� ȣ��");
        }
    }


    void Start()
    {
        Test test = new Test();
        Debug.Log(test.Power(10));
        Debug.Log(test.Power(20));

        TestA testA = new TestA();
        Debug.Log(testA.Multi(52, 273));
        Debug.Log(testA.Multi(103, 32));

        TestB testB = new TestB();
        testB.Print();
        testB.Print();

        TestC testC = new TestC();
        Debug.Log(testC.Sum(1, 100));

        //int
        Debug.Log(MyMath.Abs(52));
        Debug.Log(MyMath.Abs(-273));

        //double
        Debug.Log(MyMath.Abs(52.273));
        Debug.Log(MyMath.Abs(-32.103));

        //long
        Debug.Log(MyMath.Abs(21474836470));
        Debug.Log(MyMath.Abs(-21474836470));


        Product productA = new Product("����", 2000);
        Product productB = new Product("����", 3000);

        Debug.Log(productA.id + ":" + productA.name);
        Debug.Log(productB.id + ":" + productB.name);
        Debug.Log(Product.counter + "�� �����Ǿ����ϴ�.");

        Product2 product2 = new Product2("����", 1000);

    }

    void Update()
    {
        
    }
}
