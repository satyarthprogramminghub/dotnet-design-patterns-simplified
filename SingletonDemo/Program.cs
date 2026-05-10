// Top level statements are used in this program, which is a feature of C# 9.0 and later.

//1- Before implementing the singleton pattern, each time we create an instance of the class, the counter is incremented.
//var beforeSingleton1 = new SingletonDemo.Before.BeforeSingleton();
//beforeSingleton1.GetCounter(); // Output: 1 

//var beforeSingleton2 = new SingletonDemo.Before.BeforeSingleton();
//beforeSingleton2.GetCounter(); // Output: 2

//var beforeSingleton3 = new SingletonDemo.Before.BeforeSingleton();
//beforeSingleton3.GetCounter(); // Output: 3

//2- After implementing the singleton pattern, only one instance of the class is created,
//and the counter is incremented only once, regardless of how many times we call GetInstance().
//var singleton1 = SingletonDemo.After.Singleton.GetInstance();
//singleton1.GetCounter(); // Output: 1

//var singleton2 = SingletonDemo.After.Singleton.GetInstance();
//singleton2.GetCounter(); // Output: 1

//var singleton3 = SingletonDemo.After.Singleton.GetInstance();
//singleton3.GetCounter(); // Output: 1

//3- Nested class can break the singleton pattern if it inherits from the singleton class
// so make the singleton class sealed to prevent inheritance and ensure that only one instance of the class can be created.
//var nestedSingleton = new SingletonDemo.After.Singleton.NestedInSingleton();
//nestedSingleton.GetCounter();

// 4- In a multithreaded environment, the singleton pattern can be implemented using a thread-safe approach
// to ensure that only one instance of the class is created, even when multiple threads are trying to access it simultaneously.
Thread thread1 = new Thread(() =>
{
    var singleton1 = SingletonDemo.After.Singleton.GetInstance();
    singleton1.GetCounter(); // Output: 1
});
thread1.Start();

Thread thread2 = new Thread(() =>
{
    var singleton2 = SingletonDemo.After.Singleton.GetInstance();
    singleton2.GetCounter(); // Output: 1
});
thread2.Start();