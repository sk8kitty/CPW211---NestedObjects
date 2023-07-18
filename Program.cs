using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    FullName = "Annemarie Smith",
    Email = "annemarie@cptc.edu",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new Student()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    SchoolEmail = "homer.simpson@students.cptc.edu",
    PhoneNumber = "2534585580",
    AssignedAdvisor = compSciAdvisor
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");