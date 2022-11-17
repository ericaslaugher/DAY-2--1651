using DemoStatic;

Student john = new Student("John","21");
Student paul = new Student("Paul","21");

john.ShowInfo();
paul.ShowInfo();

Student.School = "GreenWich VietNam";

john.ShowInfo();
paul.ShowInfo();