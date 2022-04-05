using System;

namespace Program
{
    class School
    {
        public string name; 
        public School(){
            Console.WriteLine("부모 클래스");
        }
    }
    class Students : School
    {
        public Students(){
            Console.WriteLine("자식 클래스");
        }
        public void printStudents(string name)
        {
            this.name = name;
            Console.WriteLine($"학생의 이름은 {name} 입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.printStudents("Park");

        }
    }
}